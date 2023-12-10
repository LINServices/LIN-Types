using LIN.Types.Developer.Interfaces;

namespace LIN.Types.Developer.Models.Projects;



public class ResourceModel : IMongoBase
{

    [BsonId]
    [BsonElement("_id")]
    [Column("_id")]
    public ObjectId Id { get; set; }

    [BsonElement("name")]
    [Column("name")]
    public string Name { get; set; } = string.Empty;

    [BsonElement("type")]
    [Column("type")]
    public ProjectTypes Type { get; set; }

    [BsonElement("status")]
    [Column("status")]
    public ProjectStatus Status { get; set; }

    [BsonElement("profile_id")]
    [Column("profile_id")]
    public int ProfileId { get; set; }

    [BsonElement("Allowed")]
    [Column("Allowed")]
    public List<AccessModel> Allowed { get; set; } = [];
}
