namespace LIN.Types.Cloud.Identity.Platform.Access.Requests;

public record ValidatePolicyRequest(
    int IdentityId,
    int OrganizationId,
    int? ApplicationId,
    string? IdentityType,
    string? IpAddress,
    string? CountryCode,
    DateTime? AtUtc);
