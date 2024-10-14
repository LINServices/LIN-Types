using Http.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Http.Extensions;

public static class HttpExtensions
{

    /// <summary>
    /// Usar swagger.
    /// </summary>
    private static bool UseSwagger { get; set; } = true;


    /// <summary>
    /// Agregar LIN Services.
    /// </summary>
    public static IServiceCollection AddLINHttp(this IServiceCollection services, bool useSwagger = true, Action<Swashbuckle.AspNetCore.SwaggerGen.SwaggerGenOptions>? options = null)
    {
        UseSwagger = useSwagger;
        services.AddSingleton<IPMiddleware>();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        if (useSwagger)
            services.AddSwaggerGen(options);

        services.AddCors(options =>
        {
            options.AddPolicy("AllowAnyOrigin",
                builder =>
                {
                    builder.AllowAnyOrigin()
                           .AllowAnyHeader()
                           .AllowAnyMethod();
                });
        });

        return services;
    }


    /// <summary>
    /// Usar rate token limit.
    /// </summary>
    /// <param name="limit">Limite.</param>
    /// <param name="time">Tiempo.</param>
    public static IApplicationBuilder UseRateTokenLimit(this IApplicationBuilder app, int limit, TimeSpan time)
    {
        RateTokenLimitingMiddleware.TimeSpan = time;
        RateTokenLimitingMiddleware.RequestLimit = limit;
        app.UseMiddleware<RateTokenLimitingMiddleware>();
        return app;
    }


    /// <summary>
    /// Agregar LIN Services.
    /// </summary>
    public static IApplicationBuilder UseLINHttp(this IApplicationBuilder app)
    {

        // Usar CORS.
        app.UseMiddleware<IPMiddleware>();
        app.UseCors("AllowAnyOrigin");

        // https.
        app.UseHttpsRedirection();

        // Swagger.
        if (UseSwagger)
        {
            app.UseSwagger();
            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("/swagger/v1/swagger.json", "API");
                config.RoutePrefix = string.Empty;
                config.InjectStylesheet("./swagger/somee.css");
            });
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        return app;

    }

}