namespace LIN.Types.Cloud.Identity.Platform.Access.Requests;

public record SeedPermissionCatalogRequest(List<PermissionCatalogEntryRequest> Entries);

public record PermissionCatalogEntryRequest(string ResourceType, string Code, string Description);
