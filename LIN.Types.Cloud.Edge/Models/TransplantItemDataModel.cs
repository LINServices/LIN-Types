namespace LIN.Types.Cloud.Edge.Models;

using LIN.Types.Cloud.Edge.Enums;

/// <summary>
/// Un contenedor dentro de un trasplante.
/// </summary>
public class TransplantItemDataModel
{
    public int Id { get; set; }

    public int TransplantId { get; set; }

    /// <summary>
    /// Registro de containers.
    /// </summary>
    public int ContainerId { get; set; }

    public TransplantItemRole Role { get; set; } = TransplantItemRole.Base;

    /// <summary>
    /// FullBackup usado para capturar el contenedor.
    /// </summary>
    public int? BackupId { get; set; }

    public string SourceDockerId { get; set; } = string.Empty;

    /// <summary>
    /// Nombre lin-hold-retired-* del origen retirado.
    /// </summary>
    public string? RetiredName { get; set; }

    /// <summary>
    /// Contenedor restaurado en el destino.
    /// </summary>
    public string? TargetDockerId { get; set; }

    /// <summary>
    /// Volúmenes creados en el destino (JSON).
    /// </summary>
    public string? NewVolumesJson { get; set; }

    /// <summary>
    /// Volúmenes del origen, para el retiro (JSON).
    /// </summary>
    public string? OldVolumesJson { get; set; }

    /// <summary>
    /// Puerto viejo → nuevo (JSON).
    /// </summary>
    public string? PortMapJson { get; set; }

    public string? Step { get; set; }
}
