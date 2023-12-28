namespace LIN.Types.Identity.Models;


public class SecurityGroupModel
{

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<AccountModel> Accounts { get; set; } = [];
    public List<SecurityGroupRoles> Roles { get; set; } = [];
    public DirectoryModel Directory { get; set; } = null!;
    public int DirectoryId { get; set; }

}