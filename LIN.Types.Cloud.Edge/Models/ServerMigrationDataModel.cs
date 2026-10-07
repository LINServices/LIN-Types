namespace LIN.Types.Cloud.Edge.Models;

using LIN.Types.Cloud.Edge.Enums;

/// <summary>
/// Migración de un contenedor de base de datos entre servidores.
/// </summary>
public class ServerMigrationDataModel
{
    public int Id { get; set; }

    public int ResourceId { get; set; }

    public int ContainerId { get; set; }

    public int SourceServerId { get; set; }

    public int TargetServerId { get; set; }

    public int? FullBackupId { get; set; }

    public ServerMigrationStatus Status { get; set; } = ServerMigrationStatus.Requested;

    public string? Step { get; set; }

    public string SourceDockerContainerId { get; set; } = string.Empty;

    public int SourcePort { get; set; }

    /// <summary>
    /// Nombre original del origen, para renombrarlo a lin-hold-retired-* y restaurarlo en rollback.
    /// </summary>
    public string SourceContainerName { get; set; } = string.Empty;

    /// <summary>
    /// Se guarda apenas se crea, para poder limpiar tras una caída.
    /// </summary>
    public string? TargetDockerContainerId { get; set; }

    public int? TargetPort { get; set; }

    /// <summary>
    /// Volúmenes creados en el destino (JSON).
    /// </summary>
    public string? TargetVolumesJson { get; set; }

    /// <summary>
    /// True tras el commit de Switching: desde ahí solo se avanza.
    /// </summary>
    public bool PointOfNoReturn { get; set; }

    public string? FailureReason { get; set; }

    /// <summary>
    /// El origen retirado se conserva hasta esta fecha.
    /// </summary>
    public DateTime? RetainUntil { get; set; }

    /// <summary>
    /// Cuándo se borró el origen retirado.
    /// </summary>
    public DateTime? RetiredAt { get; set; }

    public DateTime StartedAt { get; set; }

    /// <summary>
    /// Latido: última actividad registrada.
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    public DateTime? FinishedAt { get; set; }
}
