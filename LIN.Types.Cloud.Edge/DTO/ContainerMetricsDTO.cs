namespace LIN.Types.Cloud.Edge.DTO;

public sealed class ContainerMetricsDTO
{
    /// <summary>
    /// Identificador del contenedor.
    /// </summary>
    public string ContainerId { get; set; } = string.Empty;

    /// <summary>
    /// Nombre del contenedor.
    /// </summary>
    public string ContainerName { get; set; } = string.Empty;

    /// <summary>
    /// Marca de tiempo de la métrica.
    /// </summary>
    public DateTime Timestamp { get; set; }

    /// <summary>
    /// Uso de memoria en KB.
    /// </summary>
    public long MemoryUsageKb { get; set; }

    /// <summary>
    /// Límite de memoria en KB.
    /// </summary>
    public long MemoryLimitKb { get; set; }

    /// <summary>
    /// Uso actual de CPU.
    /// </summary>
    public long CpuUsageCurrent { get; set; }

    /// <summary>
    /// Uso máximo de CPU.
    /// </summary>
    public long CpuUsageMax { get; set; }
}