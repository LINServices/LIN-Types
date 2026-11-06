namespace LIN.Types.Cloud.Edge.Enums;

/// <summary>
/// Estado de una entrada del catálogo de actualizaciones.
/// </summary>
public enum UpdateEntryStatus
{
    /// <summary>
    /// Se está generando la instantánea de targets.
    /// </summary>
    Building = 0,

    /// <summary>
    /// Publicada: produce intentos manuales y automáticos.
    /// </summary>
    Active = 1,

    /// <summary>
    /// Cerrada (terminal): ya no produce intentos.
    /// </summary>
    Closed = 2,

    /// <summary>
    /// Falló la generación de targets.
    /// </summary>
    BuildFailed = 3
}
