namespace LIN.Types.Identity.Models;


public class SecurityGroupMember
{
    public AccountModel Account { get; set; } = null!;
    public SecurityGroupModel SecurityGroup { get; set; } = null!;
    public int AccountId { get; set; }
    public int SecurityGroupId { get; set; }
}
