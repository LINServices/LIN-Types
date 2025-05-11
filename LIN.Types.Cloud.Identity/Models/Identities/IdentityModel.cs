namespace LIN.Types.Cloud.Identity.Models.Identities;

public class IdentityModel
{
    public int Id { get; set; }
    public string Unique { get; set; } = string.Empty;
    public DateTime CreationTime { get; set; }
    public DateTime? EffectiveTime { get; set; }
    public DateTime? ExpirationTime { get; set; }
    public IdentityStatus Status { get; set; }
    public IdentityType Type { get; set; }
    public OrganizationModel Owner { get; set; } = null!;
    public int OwnerId { get; set; }
    public List<IdentityRolesModel> Roles { get; set; } = [];
}