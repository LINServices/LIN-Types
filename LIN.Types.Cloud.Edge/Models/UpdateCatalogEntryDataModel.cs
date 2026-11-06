namespace LIN.Types.Cloud.Edge.Models;

using LIN.Types.Cloud.Edge.Enums;

/// <summary>
/// Actualización publicada por el operador para un tipo de recurso.
/// </summary>
public class UpdateCatalogEntryDataModel
{
    public int Id { get; set; }

    /// <summary>
    /// Tipo de recurso normalizado (minúsculas), igual a <c>TransplantResourceType.Name</c>.
    /// </summary>
    public string ResourceType { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string? Notes { get; set; }

    public UpdateEntryStatus Status { get; set; } = UpdateEntryStatus.Building;

    /// <summary>
    /// Targets generados por la instantánea.
    /// </summary>
    public int TargetCount { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? ClosedAt { get; set; }
}
