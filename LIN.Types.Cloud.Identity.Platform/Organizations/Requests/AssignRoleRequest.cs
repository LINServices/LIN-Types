using LIN.Types.Cloud.Identity.Platform.Organizations.Enums;

namespace LIN.Types.Cloud.Identity.Platform.Organizations.Requests;

public record AssignRoleRequest(int IdentityId, Role Role);
