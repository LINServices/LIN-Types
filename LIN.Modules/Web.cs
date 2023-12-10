using System.Text;

namespace LIN.Modules;


public class Web
{

    public static string AddParameters(string baseUrl, Dictionary<string, string> parameters)
    {
        // Crear un objeto UriBuilder con la URL base y la ruta
        var uriBuilder = new UriBuilder(baseUrl);

        // Agregar los parámetros a la cadena de consulta
        if (parameters.Count > 0)
        {
            var queryBuilder = new StringBuilder();
            foreach (var parameter in parameters)
            {
                queryBuilder.Append($"{Uri.EscapeDataString(parameter.Key)}={Uri.EscapeDataString(parameter.Value)}&");
            }

            queryBuilder.Length--; // Eliminar el último "&"

            uriBuilder.Query = queryBuilder.ToString();
        }

        // Obtener la URL final con los parámetros agregados
        var finalUrl = uriBuilder.ToString();
        return finalUrl;
    }



}