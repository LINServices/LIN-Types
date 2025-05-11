using LIN.Types.Cloud.Identity.Models.Identities;

namespace LIN.Types.Cloud.Identity.Models;

public class MailModel
{
    public int Id { get; set; }
    public string Mail { get; set; } = null!;
    public bool IsPrincipal { get; set; }
    public bool IsVerified { get; set; }
    public AccountModel Account { get; set; } = null!;
    public int AccountId { get; set; }
}