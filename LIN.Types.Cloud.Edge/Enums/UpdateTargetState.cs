namespace LIN.Types.Cloud.Edge.Enums;

/// <summary>
/// Estado de un contenedor alcanzado por una entrada del catálogo.
/// </summary>
public enum UpdateTargetState
{
    Pending = 0,

    /// <summary>
    /// Hay un run activo sobre el target.
    /// </summary>
    InProgress = 1,

    Completed = 2,

    /// <summary>
    /// Omitido (réplicas, blue-green, sin volumen...). El motivo va en LastMessage.
    /// </summary>
    Skipped = 3,

    /// <summary>
    /// Agotó los intentos automáticos; solo el dueño o el operador pueden reintentar.
    /// </summary>
    Failed = 4,

    /// <summary>
    /// Un rollback falló; solo el reset del operador lo devuelve a Pending.
    /// </summary>
    RequiresIntervention = 5
}
