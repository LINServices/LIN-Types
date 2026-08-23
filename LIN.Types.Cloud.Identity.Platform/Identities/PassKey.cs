using LIN.Types.Cloud.Identity.Platform.Identities.Enums;

namespace LIN.Types.Cloud.Identity.Platform.Identities;

public class PassKey
{
    public string Key { get; set; } = string.Empty;
    public string User { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
    public string HubKey { get; set; } = string.Empty;
    public DateTime Time { get; set; }
    public DateTime Expiration { get; set; }
    public PassKeyStatus Status { get; set; }
}
