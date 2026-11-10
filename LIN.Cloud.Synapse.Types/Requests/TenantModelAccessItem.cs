using System.ComponentModel.DataAnnotations;

namespace LIN.Cloud.Synapse.Types.Requests;

public class TenantModelAccessItem
{
    [Required]
    public string ModelId { get; set; } = string.Empty;

    [Required]
    public bool? IsAllowed { get; set; }
}
