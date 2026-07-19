using LIN.Cloud.Synapse.Types.Enums;

namespace LIN.Cloud.Synapse.Types.Requests;

public class UpdateTenantRequest
{
    public TenantStatus? Status { get; set; }

    public int? RateLimitPerMinute { get; set; }
}
