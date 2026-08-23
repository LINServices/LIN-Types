namespace LIN.Types.Cloud.Identity.Platform.Access.Requests;

public record GrantAccessRequest(string ObjectId, int IdentityId, List<string> PermissionCodes, DateTime? ExpiresAt);
