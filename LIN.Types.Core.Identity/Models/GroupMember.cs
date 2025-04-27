using LIN.Types.Core.Identity.Enumerations;
using LIN.Types.Core.Identity.Models.Identities;

namespace LIN.Types.Core.Identity.Models;

public class GroupMember
{
    public IdentityModel Identity { get; set; } = null!;
    public GroupModel Group { get; set; } = null!;
    public int IdentityId { get; set; }
    public int GroupId { get; set; }
    public GroupMemberAssigned AssignedType { get; set; }
}