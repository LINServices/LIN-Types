using LIN.Types.Cloud.Edge.Enums;

namespace LIN.Types.Cloud.Edge.Models;

/// <summary>
/// Ejecución (intento) de una actualización.
/// </summary>
public sealed record UpdateRunDto(int Id, int TargetId, int EntryId, int ContainerId, int ResourceId, UpdateTrigger Trigger, UpdateRunStatus Status, string? Step, string? Message, string? ImageReference, string? FromImageId, string? ToImageId, int? FullBackupId, DateTime StartedAt, DateTime UpdatedAt, DateTime? FinishedAt)
{
    /// <summary>
    /// Constructor vacío requerido por <c>ReadOneResponse</c>.
    /// </summary>
    public UpdateRunDto() : this(0, 0, 0, 0, 0, UpdateTrigger.Manual, UpdateRunStatus.Requested, null, null, null, null, null, null, default, default, null) { }
}
