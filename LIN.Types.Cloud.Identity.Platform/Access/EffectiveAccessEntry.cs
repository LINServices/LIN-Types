namespace LIN.Types.Cloud.Identity.Platform.Access;

public class EffectiveAccessEntry
{
    public int IdentityId { get; set; }
    public List<string> Permissions { get; set; } = [];
    public List<AccessSource> Sources { get; set; } = [];
}
