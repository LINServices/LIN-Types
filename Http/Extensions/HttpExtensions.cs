using Http.Middlewares;
using LIN.Access.Logger;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.HttpOverrides;
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
    private static bool UseCors { get; set; } = true;
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
    public static IServiceCollection AddLINHttp(this IServiceCollection services, bool useSwagger = true, Action<Swashbuckle.AspNetCore.SwaggerGen.SwaggerGenOptions>? options = null, bool useCors = true)
    {
        UseCors = useCors;

        // Lee X-Forwarded-Proto y X-Forwarded-Host que enviará YARP
        services.Configure<ForwardedHeadersOptions>(options =>
        {
            options.ForwardedHeaders = ForwardedHeaders.XForwardedProto | ForwardedHeaders.XForwardedHost;

            // limpia restricciones de proxies conocidos:
            options.KnownNetworks.Clear();
            options.KnownProxies.Clear();
        });

        UseSwagger = useSwagger;
        services.AddSingleton<IPMiddleware>();
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddHttpContextAccessor();

        if (useSwagger)
            services.AddSwaggerGen(options);

        if (useCors)
        {
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
        }

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
    public static WebApplication UseLINHttp(this WebApplication app, bool useGateway = false)
    {
        app.UseMiddleware<TimeMiddleware>();

        app.UseForwardedHeaders();
        if (useGateway)
            app.UseMiddleware<GatewayBasePathMiddleware>();
            
        // Usar CORS.
        app.UseMiddleware<IPMiddleware>();

        if (UseCors)
        {
            app.UseCors("AllowAnyOrigin");
        }

        var config = app.Services.GetService<IConfiguration>();

        if (config is not null)
        {
            var xformard = config["LIN:gateway"];
            if (!string.IsNullOrEmpty(xformard))
                app.UsePathBase(xformard);
        }

        app.UseRouting();
        // Swagger.
        if (UseSwagger)
        {
            app.UseSwagger(config => config.RouteTemplate = "{documentName}/swagger.json");
            app.UseSwaggerUI(config =>
            {
                config.SwaggerEndpoint("v1/swagger.json", "API");
                config.RoutePrefix = string.Empty;
                config.InjectStylesheet("./swagger/somee.css");
                config.InjectStylesheet("https://lin-experimental.github.io/cdn-private-css/somee.css");
            });
        }
        app.UseStaticFiles();

        app.MapHealthChecks("/health", new HealthCheckOptions
        {
            ResponseWriter = async (context, report) =>
            {
                var response = new
                {
                    status = report.Status.ToString(),
                    checks = report.Entries.Select(e => new
                    {
                        name = e.Key,
                        status = e.Value.Status.ToString(),
                        description = e.Value.Description
                    })
                };
            
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsJsonAsync(response);
            }
        });

        return app;
    }

    /// <summary>
    /// Agregar LIN Services de logging.
    /// </summary>
    public static IHostBuilder UseLoggingService(this IHostBuilder app, IConfiguration configuration)
    {
        LoggerExtensions.AddServiceLogging(app, configuration["logs:name"] ?? string.Empty, configuration["logs:key"] ?? string.Empty);
        return app;
    }

}