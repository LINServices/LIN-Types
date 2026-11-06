namespace LIN.Types.Cloud.Edge.Enums;

/// <summary>
/// Estado de una ejecución de actualización. De Requested a RollingBack (0-4) están activos.
/// </summary>
public enum UpdateRunStatus
{
    Requested = 0,
    BackingUp = 1,
    Updating = 2,
    Verifying = 3,
    RollingBack = 4,
    Completed = 5,

    /// <summary>
    /// Abortado antes de tocar el contenedor (por ejemplo, falló el backup).
    /// </summary>
    Aborted = 6,

    /// <summary>
    /// Falló la actualización y se restauró el backup.
    /// </summary>
    RolledBack = 7,

    /// <summary>
    /// Falló el rollback o se perdió el latido; se conserva el backup.
    /// </summary>
    RequiresIntervention = 8
}
