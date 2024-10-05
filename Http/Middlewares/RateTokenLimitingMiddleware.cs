namespace Http.Middlewares;

public class RateTokenLimitingMiddleware(RequestDelegate next)
{

    private readonly RequestDelegate _next = next;
    private static readonly Dictionary<string, (DateTime Timestamp, int RequestCount)> _userRequestLog = new();

    internal static int RequestLimit { get; set; }

    internal static TimeSpan TimeSpan { get; set; }

    public async Task InvokeAsync(HttpContext context)
    {
        // Aquí obtienes el identificador del usuario (por ejemplo, un nombre de usuario o ID único)
        var userId = context.Request.Headers["token"].FirstOrDefault();

        if (!string.IsNullOrEmpty(userId))
        {
            if (_userRequestLog.ContainsKey(userId))
            {
                var (timestamp, requestCount) = _userRequestLog[userId];

                // Verificar si el tiempo actual está dentro del mismo intervalo de tiempo (1 minuto)
                if (DateTime.UtcNow - timestamp < TimeSpan)
                {
                    if (requestCount >= RequestLimit)
                    {
                        // Si se ha excedido el límite, devolver un 429 (Too Many Requests)
                        context.Response.StatusCode = StatusCodes.Status429TooManyRequests;
                        var response = new ResponseBase()
                        {
                            Message = "Has superado el límite de solicitudes. Inténtalo de nuevo más tarde.",
                        };

                        await context.Response.WriteAsJsonAsync(response);
                        return;
                    }
                    else
                    {
                        // Aumentar el contador de solicitudes
                        _userRequestLog[userId] = (timestamp, requestCount + 1);
                    }
                }
                else
                {
                    // Reiniciar el contador y el timestamp si el intervalo de tiempo ha pasado
                    _userRequestLog[userId] = (DateTime.UtcNow, 1);
                }
            }
            else
            {
                // Agregar una nueva entrada para un usuario nuevo o sin registros previos
                _userRequestLog[userId] = (DateTime.UtcNow, 1);
            }
        }

        // Pasar la solicitud al siguiente middleware si no se excede el límite
        await _next(context);
    }

}