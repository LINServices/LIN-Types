namespace LIN.Types.Identity.Models;


public class IdentityRoles
{

    public IdentityModel Identity { get; set; } = null!;
    public int IdentityId { get; set; }
    public Roles Rol { get; set; }
    public OrganizationModel Organization { get; set; } = null!;
    public int OrganizationId { get; set; }

}