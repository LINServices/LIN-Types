namespace LIN.Types.Cloud.Edge.Models;

using LIN.Types.Cloud.Edge.Enums;

/// <summary>
/// Backup completo en frío de un contenedor de base de datos (manifiesto + volúmenes) en MinIO.
/// </summary>
public class FullBackupDataModel
{
    public int Id { get; set; }

    public int ResourceId { get; set; }

    /// <summary>
    /// Id lógico de containers.Id (sin FK: sobrevive al borrado del recurso).
    /// </summary>
    public int ContainerId { get; set; }

    public int SourceServerId { get; set; }

    public DatabaseEngine Engine { get; set; } = DatabaseEngine.Postgres;

    /// <summary>
    /// False para backups de apps, donde Engine se ignora.
    /// </summary>
    public bool IsDatabase { get; set; } = true;

    public FullBackupStatus Status { get; set; } = FullBackupStatus.Pending;

    /// <summary>
    /// Texto de progreso.
    /// </summary>
    public string? Step { get; set; }

    public string Bucket { get; set; } = string.Empty;

    /// <summary>
    /// Prefijo de los objetos: full-backups/{resourceId}/{timestamp}/
    /// </summary>
    public string ObjectPrefix { get; set; } = string.Empty;

    /// <summary>
    /// Tag original de la imagen.
    /// </summary>
    public string ImageReference { get; set; } = string.Empty;

    /// <summary>
    /// Digest de repositorio de la imagen (repo@sha256:...).
    /// </summary>
    public string ImageDigest { get; set; } = string.Empty;

    /// <summary>
    /// Suma de los tamaños comprimidos.
    /// </summary>
    public long SizeBytes { get; set; }

    public FullBackupOrigin Origin { get; set; } = FullBackupOrigin.Manual;

    /// <summary>
    /// Migración que creó el backup, si aplica.
    /// </summary>
    public int? MigrationId { get; set; }

    public DateTime StartedAt { get; set; }

    /// <summary>
    /// Latido: última actividad registrada.
    /// </summary>
    public DateTime UpdatedAt { get; set; }

    public DateTime? FinishedAt { get; set; }

    public DateTime? ExpiresAt { get; set; }

    public string? Message { get; set; }

    public List<FullBackupVolumeDataModel> Volumes { get; set; } = [];
}
