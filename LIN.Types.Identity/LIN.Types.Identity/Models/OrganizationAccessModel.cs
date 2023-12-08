namespace LIN.Types.Identity.Models;


public class OrganizationAccessModel
{
    public OrgRoles Rol { get; set; }
    public AccountModel Member { get; set; } = new();
    public int MemberId { get; set; }
    public OrganizationModel Organization { get; set; } = new();
    public int OrganizationId { get; set; }
}