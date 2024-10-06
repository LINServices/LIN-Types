using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Concurrent;
using System.IdentityModel.Tokens.Jwt;

namespace Http.Attributes;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
public class RateLimitAttribute : ActionFilterAttribute
{
    private static ConcurrentDictionary<string, RequestInfo> _requests = new();
    private readonly int _requestLimit;
    private readonly TimeSpan _timeWindow;
    private readonly TimeSpan _blockDuration;
    private readonly string key;

    public RateLimitAttribute(int requestLimit = 20, int timeWindowSeconds = 60, int blockDurationSeconds = 60)
    {
        _requestLimit = requestLimit;
        _timeWindow = TimeSpan.FromSeconds(timeWindowSeconds);
        _blockDuration = TimeSpan.FromSeconds(blockDurationSeconds);
        this.key = Guid.NewGuid().ToString();
    }

    public override void OnActionExecuting(ActionExecutingContext context)
    {

        var userId = GetPrimaryId(context.HttpContext.Request.Headers["token"].FirstOrDefault());
        var now = DateTime.UtcNow;

        string cache = $"{key}-{userId}";

        if (_requests.TryGetValue(cache, out RequestInfo? requestInfo))
        {
            // Verificar si está bloqueado
            if (requestInfo.BlockedUntil.HasValue && requestInfo.BlockedUntil > now)
            {
                // Respuesta.
                var response = new ResponseBase()
                {
                    Response = Responses.RateLimitExceeded,
                    Message = $"Has excedido el límite de solicitudes. Intenta nuevamente después de {requestInfo.BlockedUntil - now:hh\\:mm\\:ss}."
                };
                // Bloquear la solicitud con un código 429
                context.Result = new ContentResult
                {
                    Content = System.Text.Json.JsonSerializer.Serialize(response),
                    StatusCode = StatusCodes.Status429TooManyRequests,
                    ContentType = "application/json"
                };
                return;
            }
            else if (requestInfo.BlockedUntil.HasValue && requestInfo.BlockedUntil <= now)
            {
                // Si el tiempo de bloqueo ha pasado, reiniciar el contador
                requestInfo.Reset(now);
            }

            // Verificar si está dentro del intervalo de tiempo
            if (requestInfo.LastRequestTime.Add(_timeWindow) > now)
            {
                requestInfo.RequestCount++;

                if (requestInfo.RequestCount > _requestLimit)
                {
                    // Respuesta.
                    var response = new ResponseBase()
                    {
                        Response = Responses.RateLimitExceeded,
                        Message = $"Has excedido el límite de solicitudes. Intenta nuevamente después de {requestInfo.BlockedUntil - now:hh\\:mm\\:ss}."
                    };
                    // Bloquear al usuario
                    requestInfo.BlockedUntil = now.Add(_blockDuration);
                    context.Result = new ContentResult
                    {
                        Content = System.Text.Json.JsonSerializer.Serialize(response),
                        StatusCode = StatusCodes.Status429TooManyRequests,
                        ContentType = "application/json"
                    };
                    return;
                }
            }
            else
            {
                // Reiniciar el contador si ha pasado el tiempo
                requestInfo.Reset(now);
            }
        }
        else
        {
            // Primera solicitud del usuario
            _requests.TryAdd(cache, new RequestInfo(now));
        }

        base.OnActionExecuting(context);
    }

    /// <summary>
    /// Obtener el primary id del token JWT.
    /// </summary>
    /// <param name="token">Token a validar.</param>
    private static string GetPrimaryId(string? token)
    {

        if (string.IsNullOrWhiteSpace(token))
            return string.Empty;

        try
        {
            // Decodificar el JWT sin verificar la firma
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadJwtToken(token);
            var payload = jsonToken.Payload;

            // Obtener el primary id del payload
            var primarySid = payload.FirstOrDefault(p => p.Key == "http://schemas.microsoft.com/ws/2008/06/identity/claims/primarysid").Value;

            return primarySid?.ToString() ?? "";
        }
        catch (Exception)
        {
        }
        return "";

    }
}

internal class RequestInfo
{
    public int RequestCount { get; set; }
    public DateTime LastRequestTime { get; set; }
    public DateTime? BlockedUntil { get; set; }

    public RequestInfo(DateTime requestTime)
    {
        LastRequestTime = requestTime;
        RequestCount = 1;
        BlockedUntil = null;
    }

    public void Reset(DateTime requestTime)
    {
        LastRequestTime = requestTime;
        RequestCount = 1;
        BlockedUntil = null;
    }
}