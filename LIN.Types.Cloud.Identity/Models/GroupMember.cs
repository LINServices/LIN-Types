namespace LIN.Types.Cloud.Identity.Models;


public class GroupMember
{

    public IdentityModel Identity { get; set; } = null!;
    public GroupModel Group { get; set; } = null!;

    public int IdentityId { get; set; }
    public int GroupId { get; set; }

    public GroupMemberTypes Type { get; set; }


}