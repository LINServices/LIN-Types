namespace LIN.Types.Cloud.Identity.Models;

public class GroupRolesModel
{
    public GroupModel Group { get; set; } = null!;
    public GroupRoles Rol { get; set; }

    public int GroupId { get; set; }

}
