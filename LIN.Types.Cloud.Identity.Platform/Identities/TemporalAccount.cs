using LIN.Types.Cloud.Identity.Platform.Identities.Enums;

namespace LIN.Types.Cloud.Identity.Platform.Identities;

public class TemporalAccount
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string VerificationCode { get; set; } = string.Empty;
    public IdentityProvider Provider { get; set; }
    public int OrganizationId { get; set; }
}
