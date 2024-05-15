using Microsoft.Extensions.Configuration;

namespace Http.Services;


public static class Configuration
{


    /// <summary>
    /// Estancia de la configuración.
    /// </summary>
    private static IConfiguration? Config;


    /// <summary>
    /// El servicio esta iniciado.
    /// </summary>
    private static readonly bool IsStart = false;



    /// <summary>
    /// Obtener una ruta.
    /// </summary>
    /// <param name="route">Ruta.</param>
    public static string GetConfiguration(string route)
    {

        if (!IsStart || Config == null)
        {
            var configBuilder = new ConfigurationBuilder()
                     .SetBasePath(Directory.GetCurrentDirectory())
                      .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Config = configBuilder.Build();
        }

        return Config[route] ?? string.Empty;

    }


}