namespace LIN.Types.Developer.Models.Projects;


public class ResourceAppModel : ResourceModel
{

    [BsonElement("app_code")]
    [Column("app_code")]
    public string AppCode { get; set; } = string.Empty;


    [BsonElement("app_key")]
    [Column("app_key")]
    public string AppKey { get; set; } = string.Empty;

}