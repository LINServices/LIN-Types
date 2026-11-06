namespace LIN.Types.Cloud.Edge.Models;

/// <summary>
/// Solicitud para definir la ventana de mantenimiento de un recurso. Un solo constructor público: se enlaza desde el cuerpo HTTP.
/// </summary>
public sealed record SetMaintenanceWindowRequest(int StartHour, int EndHour);
