namespace LIN.Types.Cloud.Identity.Models;

public class AllowApp
{

    public int ApplicationId { get; set; }
    public ApplicationModel Application { get; set; } = null!;
    public IdentityModel Identity { get; set; } = null!;
    public int IdentityId { get; set; }
    public bool IsAllow { get; set; }
}
