using LIN.Types.Cloud.Identity.Platform.Organizations.Enums;

namespace LIN.Types.Cloud.Identity.Platform.Organizations.Requests;

public record AddGroupMemberRequest(int IdentityId, GroupMemberType Type);
