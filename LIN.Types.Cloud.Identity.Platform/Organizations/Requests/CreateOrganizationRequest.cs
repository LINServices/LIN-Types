namespace LIN.Types.Cloud.Identity.Platform.Organizations.Requests;

public record CreateOrganizationRequest(string Name, bool IsPublic, string Unique);
