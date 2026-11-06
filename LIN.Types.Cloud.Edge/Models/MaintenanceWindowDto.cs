namespace LIN.Types.Cloud.Edge.Models;

/// <summary>
/// Ventana de mantenimiento efectiva de un recurso (hora UTC).
/// </summary>
/// <param name="IsDefault">La ventana es la de configuración porque el recurso no definió una propia.</param>
public sealed record MaintenanceWindowDto(int StartHour, int EndHour, bool IsDefault)
{
    /// <summary>
    /// Constructor vacío requerido por <c>ReadOneResponse</c>.
    /// </summary>
    public MaintenanceWindowDto() : this(0, 0, true) { }
}
