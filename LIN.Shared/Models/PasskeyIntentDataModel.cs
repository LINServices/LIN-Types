using LIN.Shared.Enumerations;


namespace LIN.Shared.Models;


public class PasskeyIntentDataModel
{
    
    public string Key { get; set; } = string.Empty;

    public string User { get; set; } = string.Empty;

    public string ApplicationName { get; set; } = string.Empty;

    public string Token { get; set; } = string.Empty;

    public DateTime Hora { get; set; }

    public DateTime Expiracion { get; set; }

    public string HubKey { get; set; } = string.Empty;

    public PassKeyStatus Status { get; set; } = PassKeyStatus.Undefined;


}
