namespace LIN.Types.Cloud.Edge.Enums;

/// <summary>
/// Estado de un backup completo en frío. Los estados del 0 al 3 se consideran activos.
/// </summary>
public enum FullBackupStatus
{
    /// <summary>
    /// Creado, a la espera de que el job lo tome.
    /// </summary>
    Pending = 0,

    /// <summary>
    /// Deteniendo el contenedor de origen.
    /// </summary>
    Stopping = 1,

    /// <summary>
    /// Leyendo y comprimiendo los volúmenes.
    /// </summary>
    Archiving = 2,

    /// <summary>
    /// Finalizando la subida (checksums y manifiesto).
    /// </summary>
    Uploading = 3,

    /// <summary>
    /// Backup completo y verificado.
    /// </summary>
    Completed = 4,

    /// <summary>
    /// El backup falló.
    /// </summary>
    Failed = 5
}
