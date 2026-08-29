using MongoDB.Bson.Serialization.Attributes;

namespace LIN.Types.Cloud.Identity.Platform.Access;

/// <summary>
/// Recurso de una aplicación sobre el que se puede otorgar acceso. Se llama "AccessObject" en
/// vez de "Object" (como en plan-access.md) para no colisionar con System.Object.
/// </summary>
public class AccessObject
{
    [BsonId]
    public string Id { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public int ApplicationId { get; set; }
    public string ResourceType { get; set; } = string.Empty;

    [BsonIgnoreIfNull]
    public string? ExternalRef { get; set; }
    public DateTime CreatedAt { get; set; }
}
