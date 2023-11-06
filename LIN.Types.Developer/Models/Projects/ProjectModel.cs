using LIN.Types.Developer.Interfaces;

namespace LIN.Types.Developer.Models.Projects;


/// <summary>
/// Modelo base de un proyecto.
/// </summary>
public class ProjectModel : IMongoBase
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

    [BsonElement("account_id")]
    [Column("account_id")]
    public int AccountId { get; set; }

}
