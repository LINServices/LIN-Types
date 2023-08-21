namespace LIN.Types.Auth.Models;


public class OrganizationAccessModel
{

    public int ID { get; set; } = 0;
    public virtual AccountModel Member { get; set; }
    public OrgRoles Rol { get; set; }
    public virtual OrganizationModel Organization { get; set; }

}