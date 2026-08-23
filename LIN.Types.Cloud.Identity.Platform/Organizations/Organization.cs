

namespace LIN.Types.Cloud.Identity.Platform.Organizations;

public class Organization
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public int? DirectoryGroupId { get; set; }
    public Group? Directory { get; set; }
    public List<Group> Groups { get; set; } = [];
    public DateTime Creation { get; set; }
    public bool IsPublic { get; set; }
}
