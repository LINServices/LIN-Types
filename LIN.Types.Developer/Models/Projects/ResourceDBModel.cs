namespace LIN.Types.Developer.Models.Projects;


public class ResourceDBModel : ResourceModel
{

    [BsonElement("connection_string")]
    [Column("connection_string")]
    public string ConnectionString { get; set; } = string.Empty;


}