namespace LIN.Types.Developer.Models;

public class OTPDataModel
{
    [Column("id")]
    public int ID { get; set; }

    [Column("otp_code")]
    public string OTP { get; set; } = string.Empty;

    [Column("expiration")]
    public DateTime Vencimiento { get; set; }

    [Column("state")]
    public OTPStatus Estado { get; set; } = OTPStatus.actived;

    [Column("profile_fk")]
    public int ProfileId { get; set; }

    public ProfileDataModel Profile { get; set; } = null!;

}