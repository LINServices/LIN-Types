namespace LIN.Types.Identity.Models;


public class SecurityGroupRoles
{

    public int Id { get; set; }
    public SecurityGroupModel Group { get; set; } = null!;
    public int GroupId { get; set; }
    public Roles Rol { get; set; }

}