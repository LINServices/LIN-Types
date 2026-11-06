namespace LIN.Types.Cloud.Edge.Models;

using LIN.Types.Cloud.Edge.Enums;

/// <summary>
/// Contenedor concreto alcanzado por una entrada del catálogo. Es lo que el dueño ve y aplica.
/// </summary>
public class UpdateTargetDataModel
{
    public int Id { get; set; }

    /// <summary>
    /// Entrada del catálogo (FK con borrado en cascada).
    /// </summary>
    public int EntryId { get; set; }

    /// <summary>
    /// Id de BD del contenedor. Sin FK: la entidad es del paquete externo.
    /// </summary>
    public int ContainerId { get; set; }

    /// <summary>
    /// Recurso dueño del contenedor (desnormalizado para filtrar por dueño).
    /// </summary>
    public int ResourceId { get; set; }

    public UpdateTargetState State { get; set; } = UpdateTargetState.Pending;

    /// <summary>
    /// Intentos que terminaron en RolledBack o Aborted.
    /// </summary>
    public int Attempts { get; set; }

    public DateTime? LastAttemptAt { get; set; }

    public string? LastMessage { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
}
