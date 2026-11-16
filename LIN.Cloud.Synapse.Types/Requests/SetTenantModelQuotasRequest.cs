using System.ComponentModel.DataAnnotations;

namespace LIN.Cloud.Synapse.Types.Requests;

public class SetTenantModelQuotasRequest
{
    [Required]
    public List<TenantModelQuotaItem> Quotas { get; set; } = [];
}
