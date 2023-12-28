namespace LIN.Types.Cloud.Identity.Models;


public class GroupMember
{

    public AccountModel Account { get; set; } = null!;
    public GroupModel Group { get; set; } = null!;

    public int AccountId { get; set; }
    public int GroupId { get; set; }

}