namespace LIN.Types.Cloud.Identity.Platform.Access.Requests;

public record CreateObjectRequest(string Name, int ApplicationId, string ResourceType, int? OrganizationId, string? ExternalRef);
