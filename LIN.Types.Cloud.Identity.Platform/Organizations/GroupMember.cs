using LIN.Types.Cloud.Identity.Platform.Organizations.Enums;

namespace LIN.Types.Cloud.Identity.Platform.Organizations;

public class GroupMember
{
    public int IdentityId { get; set; }
    public int GroupId { get; set; }
    public Group Group { get; set; } = null!;
    public GroupMemberType Type { get; set; }
}
