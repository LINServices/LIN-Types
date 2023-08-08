using LIN.Developer.Types.Enumerations;

namespace LIN.Developer.Types.Models;


public class OTPDataModel
{
    public int ID { get; set; }
    public string OTP { get; set; } = string.Empty;
    public DateTime Vencimiento { get; set; }
    public int ProfileID { get; set; }
    public OTPStatus Estado { get; set; } = OTPStatus.actived;
}
