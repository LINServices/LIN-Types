namespace LIN.Types.Cloud.Identity.Models;


public class GroupModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<GroupRolesModel> Roles { get; set; } = [];
    public List<GroupMember> Members { get; set; } = [];


    public DirectoryModel Directory { get; set; } = null!;
    public int DirectoryId { get; set; }

}
