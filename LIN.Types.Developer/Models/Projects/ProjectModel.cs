using LIN.Types.Developer.Interfaces;

namespace LIN.Types.Developer.Models.Projects;


/// <summary>
/// Modelo base de un proyecto.
/// </summary>
public class ProjectModel : IMongoBase
{

    [BsonId]
    [BsonElement("_id")]
    public ObjectId Id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; } = string.Empty;

    [BsonElement("type")]
    public ProjectTypes Type { get; set; }

    [BsonElement("status")]
    public ProjectStatus Status { get; set; }

    [BsonElement("account_id")]
    public int AccountId { get; set; }

}
