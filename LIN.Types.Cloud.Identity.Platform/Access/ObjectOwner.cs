using MongoDB.Bson.Serialization.Attributes;

namespace LIN.Types.Cloud.Identity.Platform.Access;

public class ObjectOwner
{
    [BsonId]
    public string Id { get; set; } = string.Empty;
    public string ObjectId { get; set; } = string.Empty;
    public int OrganizationId { get; set; }
    public DateTime AssignedAt { get; set; }
}
