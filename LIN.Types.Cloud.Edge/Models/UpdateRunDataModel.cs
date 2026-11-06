namespace LIN.Types.Cloud.Edge.Models;

using LIN.Types.Cloud.Edge.Enums;

/// <summary>
/// Ejecución (intento) de una actualización. Es el historial. Como máximo hay una activa por recurso.
/// </summary>
public class UpdateRunDataModel
{
    public int Id { get; set; }

    /// <summary>
    /// Target actualizado (FK con borrado en cascada).
    /// </summary>
    public int TargetId { get; set; }

    /// <summary>
    /// Entrada del catálogo (desnormalizado).
    /// </summary>
    public int EntryId { get; set; }

    /// <summary>
    /// Id de BD del contenedor. Sin FK.
    /// </summary>
    public int ContainerId { get; set; }

    public int ResourceId { get; set; }

    public UpdateTrigger Trigger { get; set; }

    /// <summary>
    /// Identificador del usuario del token. Nulo si es automática.
    /// </summary>
    public string? RequestedBy { get; set; }

    public UpdateRunStatus Status { get; set; } = UpdateRunStatus.Requested;

    /// <summary>
    /// Paso legible en curso.
    /// </summary>
    public string? Step { get; set; }

    /// <summary>
    /// Detalle o error.
    /// </summary>
    public string? Message { get; set; }

    /// <summary>
    /// Referencia de la imagen del contenedor.
    /// </summary>
    public string? ImageReference { get; set; }

    public string? FromImageId { get; set; }

    public string? ToImageId { get; set; }

    /// <summary>
    /// Backup en frío de este run. Sin FK.
    /// </summary>
    public int? FullBackupId { get; set; }

    public string? OldDockerContainerId { get; set; }

    public string? NewDockerContainerId { get; set; }

    public DateTime StartedAt { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Latido (cada 30 s mientras el run está activo).
    /// </summary>
    public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? FinishedAt { get; set; }
}
