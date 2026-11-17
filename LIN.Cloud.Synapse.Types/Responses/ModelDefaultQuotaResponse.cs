using LIN.Cloud.Synapse.Types.Enums;

namespace LIN.Cloud.Synapse.Types.Responses;

/// <summary>
/// Límite de tokens por defecto de un modelo en un periodo.
/// </summary>
public class ModelDefaultQuotaResponse
{
    public QuotaPeriod Period { get; set; }
    public long? MaxInputTokens { get; set; }
    public long? MaxOutputTokens { get; set; }
}
