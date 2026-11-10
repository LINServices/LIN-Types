using LIN.Types.Cloud.Identity.Platform.Identities.Enums;

namespace LIN.Types.Cloud.Identity.Platform.Identities.Requests;

public class CreateAccountRequest
{
    public string Unique { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public AccountVisibility Visibility { get; set; }
    public AccountType AccountType { get; set; }
    public IdentityProvider Provider { get; set; }
}
