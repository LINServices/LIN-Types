namespace LIN.Types.Developer.Models.Projects;


public class ProjectDBModel : ProjectModel
{

    [BsonElement("connection_string")]
    public string ConnectionString { get; set; } = string.Empty;


}