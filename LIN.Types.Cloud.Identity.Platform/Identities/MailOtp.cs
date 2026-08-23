namespace LIN.Types.Cloud.Identity.Platform.Identities;

public class MailOtp
{
    public int MailId { get; set; }
    public Mail Mail { get; set; } = null!;
    public int OtpId { get; set; }
    public Otp Otp { get; set; } = null!;
}
