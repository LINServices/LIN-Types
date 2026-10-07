namespace LIN.Types.Cloud.Edge.Models;

/// <summary>
/// Volumen respaldado dentro de un backup completo.
/// </summary>
public class FullBackupVolumeDataModel
{
    public int Id { get; set; }

    public int FullBackupId { get; set; }

    [System.Text.Json.Serialization.JsonIgnore]
    public FullBackupDataModel? FullBackup { get; set; }

    public string VolumeName { get; set; } = string.Empty;

    public string MountPath { get; set; } = string.Empty;

    /// <summary>
    /// Nombre del objeto dentro del prefijo del backup.
    /// </summary>
    public string ObjectName { get; set; } = string.Empty;

    public long CompressedBytes { get; set; }

    public long? UncompressedBytes { get; set; }

    /// <summary>
    /// SHA-256 hexadecimal del archivo comprimido.
    /// </summary>
    public string Sha256 { get; set; } = string.Empty;

    public int OwnerUid { get; set; }

    public int OwnerGid { get; set; }

    /// <summary>
    /// Modo de la raíz del volumen en octal (p. ej. 0700).
    /// </summary>
    public string Mode { get; set; } = string.Empty;

    public bool IsAnonymous { get; set; }
}
