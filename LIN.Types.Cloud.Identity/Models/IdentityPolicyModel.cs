namespace LIN.Types.Cloud.Identity.Models;

public class IdentityPolicyModel
{
    public IdentityModel Identity { get; set; } = null!;
    public PolicyModel Policy { get; set; } = null!;
    public int IdentityId { get; set; }
    public int PolicyId { get; set; }
}