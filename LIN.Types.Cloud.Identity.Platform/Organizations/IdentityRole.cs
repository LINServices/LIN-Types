using LIN.Types.Cloud.Identity.Platform.Organizations.Enums;

namespace LIN.Types.Cloud.Identity.Platform.Organizations;

public class IdentityRole
{
    public Role Role { get; set; }
    public int IdentityId { get; set; }
    public int OrganizationId { get; set; }
    public Organization Organization { get; set; } = null!;
}
