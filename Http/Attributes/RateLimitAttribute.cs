using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Collections.Concurrent;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Http.Attributes;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class)]
/// <summary>
/// Atributo que limita la cantidad de solicitudes permitidas por usuario.
/// </summary>
public class RateLimitAttribute(int requestLimit = 20, int timeWindowSeconds = 60, int blockDurationSeconds = 60) : ActionFilterAttribute
{

    /// <summary>
    /// Registro de solicitudes por identificador.
    /// </summary>
    private static readonly ConcurrentDictionary<string, RequestInfo> _requests = new();

    /// <summary>
    /// Límite máximo de solicitudes permitidas.
    /// </summary>
    private readonly int _requestLimit = requestLimit;

    /// <summary>
    /// Intervalo de tiempo para contar solicitudes.
    /// </summary>
    private readonly TimeSpan _timeWindow = TimeSpan.FromSeconds(timeWindowSeconds);

    /// <summary>
    /// Duración del bloqueo cuando se excede el límite.
    /// </summary>
    private readonly TimeSpan _blockDuration = TimeSpan.FromSeconds(blockDurationSeconds);

    /// <summary>
    /// Clave única para diferenciar instancias.
    /// </summary>
    private readonly string _key = Guid.NewGuid().ToString();

    /// <summary>
    /// Valida la frecuencia de solicitudes antes de ejecutar la acción.
    /// </summary>
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        // Obtener el identificador primario del usuario a partir del token.
        var userId = GetPrimaryId(context.HttpContext.Request.Headers["token"].FirstOrDefault());
        var now = DateTime.UtcNow;

        var cacheKey = $"{_key}-{userId}";

        if (_requests.TryGetValue(cacheKey, out RequestInfo? requestInfo))
        {
            // Verificar si el usuario está bloqueado.
            if (requestInfo.BlockedUntil.HasValue && requestInfo.BlockedUntil > now)
            {
                // Respuesta.
                var response = new ResponseBase()
                {
                    Response = Responses.RateLimitExceeded,
                    Message = $"Has excedido el límite de solicitudes. Intenta nuevamente después de {requestInfo.BlockedUntil - now:hh\\:mm\\:ss}."
                };
                // Bloquear la solicitud con un código 429.
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
                // Si el tiempo de bloqueo ha pasado, reiniciar el contador.
                requestInfo.Reset(now);
            }

            // Verificar si está dentro del intervalo de tiempo.
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
                    // Bloquear al usuario.
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
                // Reiniciar el contador si ha pasado el tiempo.
                requestInfo.Reset(now);
            }
        }
        else
        {
            // Primera solicitud del usuario.
            _requests.TryAdd(cacheKey, new RequestInfo(now));
        }

        base.OnActionExecuting(context);
    }

    /// <summary>
    /// Obtiene el identificador primario del token JWT.
    /// </summary>
    /// <param name="token">Token a validar.</param>
    private static string GetPrimaryId(string? token)
    {

        if (string.IsNullOrWhiteSpace(token))
            return string.Empty;

        try
        {
            // Decodificar el JWT sin verificar la firma.
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadJwtToken(token);
            var payload = jsonToken.Payload;

            // Obtener el identificador principal del payload.
            var primarySid = payload.FirstOrDefault(p => p.Key == ClaimTypes.PrimarySid).Value;

            return primarySid?.ToString() ?? "";
        }
        catch (Exception)
        {
            // Ignorar errores de decodificación.
        }
        return "";

    }
}

internal class RequestInfo
{
    /// <summary>
    /// Cantidad de solicitudes realizadas.
    /// </summary>
    public int RequestCount { get; set; }

    /// <summary>
    /// Momento de la última solicitud.
    /// </summary>
    public DateTime LastRequestTime { get; set; }

    /// <summary>
    /// Tiempo hasta el cual el usuario está bloqueado.
    /// </summary>
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