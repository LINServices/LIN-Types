namespace LIN.Types.Cloud.Identity.Models;

public class PolicyModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PolicyEffect Effect { get; set; }
    public DateTime CreatedAt { get; set; }
    public IdentityModel CreatedBy { get; set; } = null!;
    public int CreatedById { get; set; }
    public OrganizationModel? Owner { get; set; } = null!;
    public int OwnerId { get; set; }
    public List<TimeAccessPolicy> TimeAccessPolicies { get; set; } = [];
    public List<IpAccessPolicy> IpAccessPolicies { get; set; } = [];
    public List<IdentityTypePolicy> IdentityTypePolicies { get; set; } = [];
}