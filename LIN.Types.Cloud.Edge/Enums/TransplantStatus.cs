namespace LIN.Types.Cloud.Edge.Enums;

/// <summary>
/// Estado de un trasplante. Los estados del 0 al 6 se consideran activos.
/// </summary>
public enum TransplantStatus
{
    Requested = 0,
    Capturing = 1,
    Restoring = 2,
    Starting = 3,
    Verifying = 4,
    Switching = 5,

    /// <summary>
    /// Revirtiendo: reiniciando el origen y limpiando el destino.
    /// </summary>
    RollingBack = 6,

    Completed = 7,
    Failed = 8,
    RolledBack = 9
}
