namespace LIN.Types.Cloud.Identity.Platform.Identities;

public class Mail
{
    public int Id { get; set; }
    public string Address { get; set; } = string.Empty;
    public bool IsPrincipal { get; set; }
    public bool IsVerified { get; set; }
    public int AccountId { get; set; }
    public Account Account { get; set; } = null!;
}
