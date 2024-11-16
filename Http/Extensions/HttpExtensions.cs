using Http.Middlewares;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
#if NET9_0_OR_GREATER
using Scalar.AspNetCore;
#endif
namespace Http.Extensions;

public static class HttpExtensions
{

    /// <summary>
    /// Usar swagger.
    /// </summary>
    private static bool UseSwagger { get; set; } = true;
    internal static Func<object>? Func { get; set; } = null;


    /// <summary>
    /// Agregar LIN Services.
    /// </summary>
    public static IServiceCollection AddDatabaseAction(this IServiceCollection services, Func<object>? execute = null)
    {
        Func = execute;
        return services;
    }


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
        {
#if NET9_0_OR_GREATER
            services.AddOpenApi();
#elif NET6_0_OR_GREATER
            services.AddSwaggerGen(options);
#endif
        }

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

#if NET9_0_OR_GREATER

            if (app is IEndpointRouteBuilder endpointRouteBuilder)
            {
                endpointRouteBuilder.MapOpenApi();
                endpointRouteBuilder.MapScalarApiReference(options =>
                {
                    options.DarkMode = true;
                    options.Theme = ScalarTheme.BluePlanet;
                });
            }
#elif NET6_0_OR_GREATER
            app.UseSwagger();
            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("/swagger/v1/swagger.json", "API");
                config.RoutePrefix = string.Empty;
                config.InjectStylesheet("./swagger/somee.css");
            });
#endif
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        return app;

    }

}