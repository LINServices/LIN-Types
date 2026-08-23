using MongoDB.Bson.Serialization.Attributes;

namespace LIN.Types.Cloud.Identity.Platform.Access;

public class PermissionCatalogEntry
{
    [BsonId]
    public string Id { get; set; } = string.Empty;
    public int ApplicationId { get; set; }
    public string ResourceType { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}
