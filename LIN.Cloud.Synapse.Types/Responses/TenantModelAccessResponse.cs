using LIN.Cloud.Synapse.Types.Enums;

namespace LIN.Cloud.Synapse.Types.Responses;

public class TenantModelAccessResponse
{
    public string ModelId { get; set; } = string.Empty;
    public string Provider { get; set; } = string.Empty;
    public ModelCapability Capabilities { get; set; }
    public bool IsEnabled { get; set; }
    public bool AvailableByDefault { get; set; }
    public bool? Override { get; set; }
    public bool IsAllowed { get; set; }
    public ModelAccessSource Source { get; set; }
}
