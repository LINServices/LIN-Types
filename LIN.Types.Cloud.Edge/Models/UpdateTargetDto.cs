using LIN.Types.Cloud.Edge.Enums;

namespace LIN.Types.Cloud.Edge.Models;

/// <summary>
/// Contenedor alcanzado por una entrada del catálogo.
/// </summary>
public sealed record UpdateTargetDto(int Id, int EntryId, int ContainerId, int ResourceId, UpdateTargetState State, int Attempts, DateTime? LastAttemptAt, string? LastMessage)
{
    /// <summary>
    /// Constructor vacío requerido por <c>ReadOneResponse</c>.
    /// </summary>
    public UpdateTargetDto() : this(0, 0, 0, 0, UpdateTargetState.Pending, 0, null, null) { }
}
