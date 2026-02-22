namespace LIN.Types.Cloud.Edge.DTO;

public class LogDtoModel
{
    /// <summary>
    /// Identificador del contenedor.
    /// </summary>
    public string ContainerId { get; set; } = string.Empty;

    /// <summary>
    /// Marca de tiempo del log.
    /// </summary>
    public DateTime Timestamp { get; set; }

    /// <summary>
    /// Mensaje del log.
    /// </summary>
    public string Message { get; set; } = string.Empty;
}