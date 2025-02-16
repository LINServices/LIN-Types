namespace LIN.Types.Cloud.Identity.Models;

public class ApplicationRestrictionModel
{
    public int Id { get; set; }
    public ApplicationModel Application { get; set; } = null!;
    public int ApplicationId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public int MaxSessions { get; set; }
    public bool AllowPersonalAccounts { get; set; } = true;
    public bool AllowWorkAccounts { get; set; } = true;
    public bool AllowEducationsAccounts { get; set; } = true;
    public bool RestrictedByIdentities { get; set; }
}