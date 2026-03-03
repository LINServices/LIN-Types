namespace LIN.Types.Developer.Models;

public class ResourceRelationModel
{
    public int Id { get; set; }
    public int ResourceId { get; set; }
    public int RelatedResourceId { get; set; }

    public ProjectDataModel Resource { get; set; }
    public ProjectDataModel RelatedResource { get; set; }

    public ResourceRelationType RelationType { get; set; }
}