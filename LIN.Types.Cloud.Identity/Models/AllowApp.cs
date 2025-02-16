namespace LIN.Types.Cloud.Identity.Models;

public class AllowApp
{
    public ApplicationRestrictionModel Application { get; set; } = null!;
    public IdentityModel Identity { get; set; } = null!;
    public int IdentityId { get; set; }
    public int ApplicationRestrictionId { get; set; }
    public bool IsAllow { get; set; }
}
