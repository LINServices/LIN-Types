using System.Text.Json;
using MongoDB.Bson.Serialization.Attributes;

namespace LIN.Types.Cloud.Identity.Platform.Access;

public class AccessGrant
{
    [BsonId]
    public string Id { get; set; } = string.Empty;
    public string ObjectId { get; set; } = string.Empty;
    public int IdentityId { get; set; }
    public int GrantedBy { get; set; }
    public DateTime GrantedAt { get; set; }
    public DateTime? ExpiresAt { get; set; }
    public List<string> PermissionCodes { get; set; } = [];

    [BsonIgnoreIfNull]
    public DateTime? UpdatedAt { get; set; }

    [BsonIgnoreIfNull]
    public JsonElement? Metadata { get; set; }
}
