namespace LIN.Types.Cloud.Edge.Models;

/// <summary>
/// Ventana de mantenimiento propia de un recurso para las actualizaciones automáticas de contenedores.
/// </summary>
public class ResourceMaintenanceWindowDataModel
{
    /// <summary>
    /// Recurso dueño de la ventana (clave primaria, sin identity).
    /// </summary>
    public int ResourceId { get; set; }

    /// <summary>
    /// Hora UTC de inicio (0-23, inclusive).
    /// </summary>
    public int StartHour { get; set; }

    /// <summary>
    /// Hora UTC de fin (0-23, exclusiva). Igual al inicio significa sin restricción; menor que el inicio cruza la medianoche.
    /// </summary>
    public int EndHour { get; set; }

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
