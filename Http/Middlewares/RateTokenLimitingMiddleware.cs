using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Http.Middlewares;

/// <summary>
/// Middleware que limita la cantidad de solicitudes por usuario mediante un token JWT.
/// </summary>
public class RateTokenLimitingMiddleware(RequestDelegate next)
{

    /// <summary>
    /// Registro de solicitudes realizadas por cada usuario.
    /// </summary>
    private static readonly Dictionary<string, (DateTime Timestamp, int RequestCount)> _userRequestLog = new();


    /// <summary>
    /// Límite máximo de solicitudes permitidas por intervalo.
    /// </summary>
    internal static int RequestLimit { get; set; }


    /// <summary>
    /// Duración del intervalo en el cual se contabilizan las solicitudes.
    /// </summary>
    internal static TimeSpan TimeWindow { get; set; }


    /// <summary>
    /// Procesa la solicitud y aplica el límite de solicitudes configurado.
    /// </summary>
    public async Task InvokeAsync(HttpContext context)
    {
        // Obtener el identificador primario del usuario a partir del token.
        var userId = GetPrimaryId(context.Request.Headers["token"].FirstOrDefault());

        // Si se identificó un usuario.
        if (!string.IsNullOrEmpty(userId))
        {
            if (_userRequestLog.ContainsKey(userId))
            {
                var (timestamp, requestCount) = _userRequestLog[userId];

                // Verificar si la solicitud se encuentra dentro del intervalo configurado.
                if (DateTime.UtcNow - timestamp < TimeWindow)
                {
                    if (requestCount >= RequestLimit)
                    {
                        // Si se ha excedido el límite, devolver un 429 (Too Many Requests)
                        context.Response.StatusCode = StatusCodes.Status429TooManyRequests;
                        var response = new ResponseBase()
                        {
                            Response = Responses.RateLimitExceeded,
                            Message = "Has superado el límite de solicitudes. Inténtalo de nuevo más tarde.",
                        };

                        await context.Response.WriteAsJsonAsync(response);
                        return;
                    }
                    else
                    {
                        // Aumentar el contador de solicitudes.
                        _userRequestLog[userId] = (timestamp, requestCount + 1);
                    }
                }
                else
                {
                    // Reiniciar el contador y el timestamp si el intervalo de tiempo ha pasado.
                    _userRequestLog[userId] = (DateTime.UtcNow, 1);
                }
            }
            else
            {
                // Agregar una nueva entrada para un usuario nuevo o sin registros previos.
                _userRequestLog[userId] = (DateTime.UtcNow, 1);
            }
        }


        // Pasar la solicitud al siguiente middleware si no se excede el límite.
        await next(context);
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