using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace Http.Extensions;

public class CustomOperationFilter<T>(string headerName) : IOperationFilter where T : Attribute
{

    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        // Obtener el atributo SwaggerHeaderAttribute del método del controlador
        var swaggerHeaderAttributes = context.MethodInfo
            .GetCustomAttributes<T>();

        // Obtener atributos a nivel de controlador (clase)
        var controllerAttributes = context.MethodInfo.DeclaringType
                                  .GetCustomAttributes<T>();

        // Combinar ambos conjuntos de atributos
        var allAttributes = swaggerHeaderAttributes.Concat(controllerAttributes);

        foreach (var attr in allAttributes)
        {
            // Crear una definición de parámetro de header
            var headerParameter = new OpenApiParameter
            {
                Name = headerName,
                In = ParameterLocation.Header,
                Description = "token de autorización.",
                Required = true,
                Schema = new OpenApiSchema
                {
                    Type = "string"
                }
            };

            // Agregar el parámetro a la lista de parámetros de la operación de Swagger
            operation.Parameters.Add(headerParameter);
        }
    }
}