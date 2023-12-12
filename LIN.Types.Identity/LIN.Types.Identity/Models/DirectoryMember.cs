namespace LIN.Types.Identity.Models;


public class DirectoryMember
{

    public DirectoryModel Directory { get; set; } = null!;
    public IdentityModel Identity { get; set; } = null!;
    public int IdentityId { get; set; }
    public int DirectoryId { get; set; }
    public DirectoryRoles Rol { get; set; }

}
