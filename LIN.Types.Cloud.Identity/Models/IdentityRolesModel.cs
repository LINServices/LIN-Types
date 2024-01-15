namespace LIN.Types.Cloud.Identity.Models;

public class IdentityRolesModel
{
    public IdentityModel Identity { get; set; } = null!;
    public Roles Rol { get; set; }
    public int IdentityId { get; set; }

    public OrganizationModel Organization { get; set; } = null!;
    public int OrganizationId { get; set; }

}
