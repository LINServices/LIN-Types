namespace LIN.Types.Cloud.Identity.Platform.Organizations;

public class Group
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public int IdentityId { get; set; }
    public int OrganizationId { get; set; }
    public Organization Organization { get; set; } = null!;
    public List<GroupMember> Members { get; set; } = [];
}
