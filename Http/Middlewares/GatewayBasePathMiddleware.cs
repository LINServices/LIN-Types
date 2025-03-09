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
        else
        {
#if !DEBUG
            context.Response.StatusCode = 404;
            await context.Response.WriteAsJsonAsync(new ResponseBase()
            {
                Response = Responses.Unauthorized,
                Message = "Esta aplicación solo puede ser accedida desde el manejador API Gateway de LIN Platform"
            });
            return;
#endif
        }

        await _next(context);
    }
}