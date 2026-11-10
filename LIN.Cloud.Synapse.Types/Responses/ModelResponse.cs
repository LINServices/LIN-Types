using LIN.Cloud.Synapse.Types.Enums;

namespace LIN.Cloud.Synapse.Types.Responses;

public class ModelResponse
{
    public Guid Id { get; set; }
    public string ModelId { get; set; } = string.Empty;
    public string Provider { get; set; } = string.Empty;
    public string ProviderModelName { get; set; } = string.Empty;
    public ModelCapability Capabilities { get; set; }
    public bool IsEnabled { get; set; }
    public decimal InputPricePerMillionTokens { get; set; }
    public decimal OutputPricePerMillionTokens { get; set; }
    public bool AvailableByDefault { get; set; }
    public decimal InputCostPerMillionTokens { get; set; }
    public decimal OutputCostPerMillionTokens { get; set; }
    public DateTime? PricingEffectiveFrom { get; set; }
}
