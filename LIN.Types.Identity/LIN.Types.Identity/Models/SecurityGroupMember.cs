namespace LIN.Types.Identity.Models;


public class SecurityGroupMember
{
    public AccountModel Account { get; set; }
    public SecurityGroupModel SecurityGroup { get; set; }
    public int AccountId { get; set; }
    public int SecurityGroupId { get; set; }
}
