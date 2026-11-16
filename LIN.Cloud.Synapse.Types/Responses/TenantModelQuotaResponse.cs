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
    public DateTime UpdatedAt { get; set; }
}
