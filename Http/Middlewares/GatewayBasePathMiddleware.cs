namespace Http.Middlewares;

public class GatewayBasePathMiddleware(RequestDelegate next)
{

    private readonly RequestDelegate _next = next;

    public async Task Invoke(HttpContext context)
    {


        if (context.Request.Headers.TryGetValue("x-gateway", out var gatewayValue) && !string.IsNullOrWhiteSpace(gatewayValue))
        {
            var gatewayPath = $"/{gatewayValue}";

            if (context.Request.Path.StartsWithSegments(gatewayPath, out var remainingPath))
            {
                // Si Path comienza con el valor de x-gateway, lo eliminamos
                context.Request.Path = remainingPath;
            }

            if (!context.Request.PathBase.StartsWithSegments(gatewayPath))
            {
                // Si Path comienza con el valor de x-gateway, lo eliminamos
                context.Request.PathBase = gatewayPath;
            }
        }
        await _next(context);
    }
}