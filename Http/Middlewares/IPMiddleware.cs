namespace Http.Middlewares;

public class IPMiddleware : IMiddleware
{

    /// <summary>
    /// Invocación del Middleware.
    /// </summary>
    /// <param name="context">Contexto HTTP.</param>
    /// <param name="next">Pipeline</param>
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        // Obtener la IP.
        var ip = context.Connection.RemoteIpAddress;

        // Validar la IP.
        if (ip is null)
        {
            context.Response.StatusCode = 400;
            await context.Response.WriteAsJsonAsync(new ResponseBase
            {
                Message = "La IP del cliente no pudo ser resuelta.",
                Response = Responses.Unauthorized
            });
            return;
        }

        // Item de IP.
        context.Items.Add("IP", ip);

        // Headers.
        context.Response.Headers.Append("client-ip", ip.MapToIPv4().ToString());
        context.Response.Headers.XPoweredBy = "LIN Cloud Platform";

        // Pipeline.
        await next(context);
    }

}