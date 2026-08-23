using LIN.Types.Cloud.Identity.Platform.Identities.Enums;

namespace LIN.Types.Cloud.Identity.Platform.Identities;

public class Account
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Profile { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public AccountVisibility Visibility { get; set; }
    public AccountType AccountType { get; set; }
    public int IdentityId { get; set; }
    public Identity Identity { get; set; } = null!;
}
