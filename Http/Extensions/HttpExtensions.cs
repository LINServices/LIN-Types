using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Http.Extensions;

public static class HttpExtensions
{


    /// <summary>
    /// Agregar LIN Services.
    /// </summary>
    public static IServiceCollection AddLINHttp(this IServiceCollection services)
    {

        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();
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
    /// Agregar LIN Services.
    /// </summary>
    public static IApplicationBuilder UseLINHttp(this IApplicationBuilder app)
    {

        // Usar CORS.
        app.UseCors("AllowAnyOrigin");

        // Swagger.
        app.UseSwagger();
        app.UseSwaggerUI(config =>
        {
            config.SwaggerEndpoint("/swagger/v1/swagger.json", "API");
            config.RoutePrefix = string.Empty;
        });

        app.UseHttpsRedirection();
        app.UseStaticFiles();

     

        return app;

    }


}