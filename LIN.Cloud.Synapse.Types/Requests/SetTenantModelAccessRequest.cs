using System.ComponentModel.DataAnnotations;

namespace LIN.Cloud.Synapse.Types.Requests;

public class SetTenantModelAccessRequest
{
    [Required]
    public bool? IsAllowed { get; set; }
}
