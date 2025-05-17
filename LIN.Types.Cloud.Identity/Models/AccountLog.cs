namespace LIN.Types.Cloud.Identity.Models;

public class AccountLog
{
    public int Id { get; set; }
    public AuthenticationMethods AuthenticationMethod { get; set; }
    public DateTime Time { get; set; }
    public AccountModel Account { get; set; } = null!;
    public int AccountId { get; set; }
    public ApplicationModel? Application { get; set; } = null!;
    public int? ApplicationId { get; set; }
}