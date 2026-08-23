namespace LIN.Types.Cloud.Identity.Platform.Identities;

public class Otp
{
    public int Id { get; set; }
    public string Code { get; set; } = string.Empty;
    public DateTime ExpireTime { get; set; }
    public bool IsUsed { get; set; }
    public int AccountId { get; set; }
    public Account Account { get; set; } = null!;
}
