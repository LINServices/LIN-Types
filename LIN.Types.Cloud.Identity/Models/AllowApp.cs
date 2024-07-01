namespace LIN.Types.Cloud.Identity.Models;

public class AllowApp
{

    public int ApplicationId { get; set; }
    public ApplicationModel Application { get; set; }
    public IdentityModel Identity { get; set; }
    public int IdentityId { get; set; }
    public bool IsAllow { get; set; }
}
