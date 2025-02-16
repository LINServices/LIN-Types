namespace LIN.Types.Cloud.Identity.Models;

public class ApplicationRestrictionModel
{
    public int Id { get; set; }
    public int MaxSessions { get; set; }
    public bool AllowPersonalAccounts { get; set; } = true;
    public bool AllowWorkAccounts { get; set; } = true;
    public bool AllowEducationsAccounts { get; set; } = true;
    public bool RestrictedByIdentities { get; set; }
    public bool RestrictedByTime { get; set; }
    public ApplicationModel Application { get; set; } = null!;
    public int ApplicationId { get; set; }
    public List<ApplicationRestrictionTime> Times { get; set; } = [];
    public List<AllowApp> Allowed { get; set; } = [];
}