using LIN.Cloud.Synapse.Types.Enums;

namespace LIN.Cloud.Synapse.Types.Responses;

public class TenantResponse
{
    public int Id { get; set; }
    public TenantStatus Status { get; set; }
    public int RateLimitPerMinute { get; set; }
    public DateTime CreatedAt { get; set; }
}
