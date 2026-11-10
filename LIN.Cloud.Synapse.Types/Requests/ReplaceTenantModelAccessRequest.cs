using System.ComponentModel.DataAnnotations;

namespace LIN.Cloud.Synapse.Types.Requests;

public class ReplaceTenantModelAccessRequest
{
    [Required]
    public List<TenantModelAccessItem> Overrides { get; set; } = new();
}
