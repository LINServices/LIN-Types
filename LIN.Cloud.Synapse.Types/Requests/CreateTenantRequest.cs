using System.ComponentModel.DataAnnotations;

namespace LIN.Cloud.Synapse.Types.Requests;

public class CreateTenantRequest
{
    [Required]
    public int ResourceId { get; set; }

    [Range(1, int.MaxValue)]
    public int RateLimitPerMinute { get; set; } = 60;
}
