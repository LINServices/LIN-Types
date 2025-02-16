namespace LIN.Types.Cloud.Identity.Models;

public class OrganizationModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public GroupModel Directory { get; set; } = null!;
    public int DirectoryId { get; set; }
    public DateTime Creation { get; set; }
    public bool IsPublic { get; set; }
    public List<GroupModel> OwnedGroups { get; set; } = [];
}