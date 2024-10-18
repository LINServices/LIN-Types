namespace LIN.Types.Cloud.Identity.Models;

public class IdentityAllowedOnPolicyModel
{
    public Guid PolicyId { get; set; }
    public PolicyModel Policy { get; set; } = null!;
    public IdentityModel Identity { get; set; } = null!;
    public int IdentityId { get; set; }
}