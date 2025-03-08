﻿using Http.Middlewares;
using LIN.Access.Logger;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

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


        app.UseMiddleware<GatewayBasePathMiddleware>();
        return app;
    }


    /// <summary>
    /// Agregar LIN Services.
    /// </summary>
    public static IApplicationBuilder UseLINHttp(this IApplicationBuilder app, string? gatewayPath = null)
    {

        // Usar CORS.
        app.UseMiddleware<IPMiddleware>();

        if (gatewayPath is not null)
            app.UseMiddleware<GatewayBasePathMiddleware>();

        app.UseCors("AllowAnyOrigin");

        // https.
        app.UseHttpsRedirection();

        // Swagger.
        if (UseSwagger)
        {
            string @default = "swagger";
            app.UseSwagger(config => config.RouteTemplate = $$"""{{gatewayPath ?? @default}}/{documentName}/swagger.json""");
            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("v1/swagger.json", "API");
                config.RoutePrefix = gatewayPath ?? string.Empty;
                config.InjectStylesheet("./swagger/somee.css");
            });
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        return app;
    }

    /// <summary>
    /// Agregar LIN Services de logging.
    /// </summary>
    public static IHostBuilder UseLoggingService(this IHostBuilder app, IConfiguration configuration)
    {
        LoggerExtensions.AddServiceLogging(app, configuration["Logging:appName"] ?? string.Empty, configuration["Logging:appKey"] ?? string.Empty);
        return app;
    }

}