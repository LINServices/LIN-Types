namespace LIN.Types.Cloud.Identity.Models;

public class AllowApp
{
    public ApplicationModel Application { get; set; } = null!;
    public IdentityModel Identity { get; set; } = null!;
    public int IdentityId { get; set; }
    public int ApplicationId { get; set; }
    public bool IsAllow { get; set; }
}
