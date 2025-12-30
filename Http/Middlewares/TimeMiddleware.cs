using Global.Utilities.Network;

namespace Http.Middlewares;

public class TimeMiddleware : IMiddleware
{

    /// <summary>
    /// Invocación del Middleware.
    /// </summary>
    /// <param name="context">Contexto HTTP.</param>
    /// <param name="next">Pipeline</param>
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        System.Diagnostics.Stopwatch stopwatch = System.Diagnostics.Stopwatch.StartNew();
        await next(context);
        context.Response.Headers.Append("response-time", $"{stopwatch.ElapsedMilliseconds}ms");
    }

}