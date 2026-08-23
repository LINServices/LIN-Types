using LIN.Types.Cloud.Identity.Platform.Identities.Enums;

namespace LIN.Types.Cloud.Identity.Platform.Identities;

public class Identity
{
    public int Id { get; set; }
    public string Unique { get; set; } = string.Empty;
    public DateTime CreationTime { get; set; }
    public DateTime? EffectiveTime { get; set; }
    public DateTime? ExpirationTime { get; set; }
    public IdentityStatus Status { get; set; }
    public IdentityType Type { get; set; }
    public IdentityProvider Provider { get; set; }
    public int? OwnerOrganizationId { get; set; }
}
