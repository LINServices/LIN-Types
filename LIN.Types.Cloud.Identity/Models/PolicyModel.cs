namespace LIN.Types.Cloud.Identity.Models;

public class PolicyModel
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public IdentityModel OwnerIdentity { get; set; } = null!;
    public int OwnerIdentityId { get; set; }
    public List<IdentityModel> ApplyFor { get; set; } = [];
}