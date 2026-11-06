using LIN.Types.Cloud.Edge.Enums;

namespace LIN.Types.Cloud.Edge.Models;

/// <summary>
/// Entrada del catálogo de actualizaciones.
/// </summary>
public sealed record UpdateEntryDto(int Id, string ResourceType, string Title, string? Notes, UpdateEntryStatus Status, int TargetCount, DateTime CreatedAt, DateTime? ClosedAt)
{
    /// <summary>
    /// Constructor vacío requerido por <c>ReadOneResponse</c>.
    /// </summary>
    public UpdateEntryDto() : this(0, string.Empty, string.Empty, null, UpdateEntryStatus.Building, 0, default, null) { }
}
