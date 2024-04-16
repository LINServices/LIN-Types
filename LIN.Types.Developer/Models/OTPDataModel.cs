namespace LIN.Types.Developer.Models;


public class OTPDataModel
{
    [Column("ID")]
    public int ID { get; set; }

    [Column("OTP_CODE")]
    public string OTP { get; set; } = string.Empty;

    [Column("EXPIRATION")]
    public DateTime Vencimiento { get; set; }

    [Column("STATE")]
    public OTPStatus Estado { get; set; } = OTPStatus.actived;

    [Column("PROFILE_FK")]
    public int ProfileId { get; set; }

    public ProfileDataModel Profile { get; set; }
   
}