namespace LIN.Types.Cloud.Edge.Models;

/// <summary>
/// Contenedor reconstruido en un servidor destino a partir de un backup completo. Todavía no está en el inventario.
/// </summary>
public class RestoredContainer
{
    public int ServerId { get; set; }

    public string DockerContainerId { get; set; } = string.Empty;

    public string ContainerName { get; set; } = string.Empty;

    /// <summary>
    /// Puerto publicado en el origen → puerto publicado en el destino.
    /// </summary>
    public Dictionary<int, int> Ports { get; set; } = [];

    /// <summary>
    /// Nombre del volumen en el origen → nombre del volumen en el destino.
    /// </summary>
    public Dictionary<string, string> Volumes { get; set; } = [];
}
