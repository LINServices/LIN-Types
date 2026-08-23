using LIN.Types.Cloud.Identity.Platform.Identities.Enums;

namespace LIN.Types.Cloud.Identity.Platform.Identities;

public class AccountLog
{
    public int Id { get; set; }
    public AuthenticationMethod AuthenticationMethod { get; set; }
    public DateTime Time { get; set; }
    public int AccountId { get; set; }
    public Account Account { get; set; } = null!;
    public int? ApplicationId { get; set; }
    public Application? Application { get; set; }
}
