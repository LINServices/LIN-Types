namespace LIN.Types.Cloud.Edge.Models;

using LIN.Types.Cloud.Edge.Enums;

/// <summary>
/// Trasplante en frío de un recurso completo (capturar, restaurar, verificar, conmutar, retirar).
/// </summary>
public class TransplantDataModel
{
    public int Id { get; set; }

    public int ResourceId { get; set; }

    public TransplantPurpose Purpose { get; set; }

    public TransplantStatus Status { get; set; } = TransplantStatus.Requested;

    /// <summary>
    /// Subpaso legible del estado actual.
    /// </summary>
    public string? Step { get; set; }

    public int SourceServerId { get; set; }

    public int? TargetServerId { get; set; }

    /// <summary>
    /// Solo para migraciones de región.
    /// </summary>
    public int? TargetRegionId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Latido: última actividad registrada.
    /// </summary>
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? FinishedAt { get; set; }

    /// <summary>
    /// Cancelación cooperativa.
    /// </summary>
    public bool CancelRequested { get; set; }

    /// <summary>
    /// True tras confirmar la conmutación en BD: desde ahí solo se avanza.
    /// </summary>
    public bool PointOfNoReturn { get; set; }

    /// <summary>
    /// Caddy/DNS pendientes de sincronizar tras el commit.
    /// </summary>
    public bool ExternalSyncPending { get; set; }

    /// <summary>
    /// El origen retirado se conserva hasta esta fecha.
    /// </summary>
    public DateTime? RetainUntil { get; set; }

    /// <summary>
    /// Cuándo se borró el origen retirado.
    /// </summary>
    public DateTime? RetiredAt { get; set; }

    public string? Message { get; set; }

    public List<TransplantItemDataModel> Items { get; set; } = [];
}
