namespace LIN.Types.Cloud.Edge.RequestModels.Ocelot;

/// <summary>
/// Modelo de solicitud para crear un nuevo contenedor Ocelot.
/// </summary>
public class OcelotCreateRequestModel
{
    /// <summary>
    /// Nombre del gateway Ocelot.
    /// </summary>
    public string SiteName { get; set; } = string.Empty;

    /// <summary>
    /// Rutas iniciales del gateway.
    /// </summary>
    public List<OcelotRouteRequestModel> Routes { get; set; } = [];
}

/// <summary>
/// Modelo de solicitud de ruta para Ocelot.
/// </summary>
public class OcelotRouteRequestModel
{

    public string Host { get; set; } = string.Empty;

    /// <summary>
    /// Puerto de destino.
    /// </summary>
    public int Port { get; set; }

    /// <summary>
    /// Ruta de origen (upstream path).
    /// </summary>
    public string UpstreamPath { get; set; } = string.Empty;

    /// <summary>
    /// Ruta de destino (downstream path).
    /// </summary>
    public string DownstreamPath { get; set; } = string.Empty;
    public string Schema { get; set; } = string.Empty;

}

/// <summary>
/// Modelo de solicitud de ruta para Ocelot.
/// </summary>
public class OcelotRouteResponseModel
{

    public string Id { get; set; } = string.Empty;

    public string Host { get; set; } = string.Empty;

    public int Port { get; set; }
    
    public string UpstreamPath { get; set; } = string.Empty;

    public string DownstreamPath { get; set; } = string.Empty;
    public string Schema { get; set; } = string.Empty;

}