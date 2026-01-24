using Microsoft.OpenApi;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Reflection;

namespace Http.Extensions.OpenApi;

public class HeaderMapAttribute<T>(string headerName, string description = "", string type = "string") : IOperationFilter where T : Attribute
{

    /// <summary>
    /// Aplicar el filtro de operación.
    /// </summary>
    /// <param name="operation">Operación.</param>
    /// <param name="context">Contexto.</param>
    public void Apply(OpenApiOperation operation, OperationFilterContext context)
    {
        // Obtener el atributo del método del controlador
        var swaggerHeaderAttributes = context.MethodInfo.GetCustomAttributes<T>();

        // Obtener atributos a nivel de controlador (clase)
        var controllerAttributes = context.MethodInfo.DeclaringType.GetCustomAttributes<T>();

        // Combinar ambos conjuntos de atributos
        var allAttributes = swaggerHeaderAttributes.Concat(controllerAttributes);

        // Convertir el string 'type' a JsonSchemaType
        JsonSchemaType schemaType = type.ToLower() switch
        {
            "string" => JsonSchemaType.String,
            "integer" => JsonSchemaType.Integer,
            "number" => JsonSchemaType.Number,
            "boolean" => JsonSchemaType.Boolean,
            "array" => JsonSchemaType.Array,
            "object" => JsonSchemaType.Object,
            "null" => JsonSchemaType.Null,
            _ => JsonSchemaType.String
        };

        foreach (var attr in allAttributes)
        {
            // Crear una definición de parámetro de header
            var headerParameter = new OpenApiParameter
            {
                Name = headerName,
                In = ParameterLocation.Header,
                Description = description,
                Required = true,
                Schema = new OpenApiSchema
                {
                    Type = schemaType
                }
            };

            // Agregar el parámetro a la lista de parámetros de la operación de Swagger
            operation.Parameters.Add(headerParameter);
        }
    }

}