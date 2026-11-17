using LIN.Cloud.Synapse.Types.Enums;

namespace LIN.Cloud.Synapse.Types.Responses;

public class TenantModelQuotaResponse
{
    public string ModelId { get; set; } = string.Empty;
    public QuotaPeriod Period { get; set; }
    public long? MaxInputTokens { get; set; }
    public long? MaxOutputTokens { get; set; }
    public long? UsedInputTokens { get; set; }
    public long? UsedOutputTokens { get; set; }
    public DateTime WindowStart { get; set; }
    public DateTime WindowEnd { get; set; }
    public QuotaSource Source { get; set; }

    /// <summary>
    /// Última modificación del límite propio del tenant; null cuando el límite es el por defecto del modelo.
    /// </summary>
    public DateTime? UpdatedAt { get; set; }
}
