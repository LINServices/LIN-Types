namespace Http.Middlewares;

public class GatewayBasePathMiddleware(RequestDelegate next)
{

    private readonly RequestDelegate _next = next;
    public static string? BasePath = null;

    public async Task Invoke(HttpContext context)
    {
        if (BasePath is not null)
            context.Request.PathBase = $"/{BasePath}";

        await _next(context);
    }
}