using System.Text;

namespace LIN.Modules;

public class Web
{

    public static string AddParameters(string baseUrl, Dictionary<string, string> parameters)
    {
        // Crear un objeto UriBuilder con la URL base y la ruta
        UriBuilder uriBuilder = new UriBuilder(baseUrl);

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
        string finalUrl = uriBuilder.ToString();
        return finalUrl;
    }


    public static string AgregarParametros(string url, Dictionary<string, string> parametros)
    {
        var uriBuilder = new UriBuilder(url);
        var query = System.Web.HttpUtility.ParseQueryString(uriBuilder.Query);

        foreach (var parametro in parametros)
        {
            query[parametro.Key] = parametro.Value;
        }

        uriBuilder.Query = query.ToString();
        return uriBuilder.ToString();
    }


}
