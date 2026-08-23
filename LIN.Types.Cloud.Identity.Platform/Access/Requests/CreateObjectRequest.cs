namespace LIN.Types.Cloud.Identity.Platform.Access.Requests;

public record CreateObjectRequest(int ApplicationId, string ResourceType, int? OrganizationId, string? ExternalRef);
