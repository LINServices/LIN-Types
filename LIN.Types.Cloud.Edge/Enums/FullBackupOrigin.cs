namespace LIN.Types.Cloud.Edge.Enums;

/// <summary>
/// Quién originó un backup completo.
/// </summary>
public enum FullBackupOrigin
{
    /// <summary>
    /// Solicitado por el usuario.
    /// </summary>
    Manual = 0,

    /// <summary>
    /// Creado como paso de una migración de servidor.
    /// </summary>
    Migration = 1
}
