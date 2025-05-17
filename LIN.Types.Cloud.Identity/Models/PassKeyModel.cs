namespace LIN.Types.Cloud.Identity.Models;

public class PassKeyModel
{
    public string Key { get; set; } = string.Empty;
    public string User { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
    public DateTime Time { get; set; }
    public DateTime Expiration { get; set; }
    public string HubKey { get; set; } = string.Empty;
    public PassKeyStatus Status { get; set; } = PassKeyStatus.Undefined;
}