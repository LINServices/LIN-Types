namespace LIN.Types.Identity.Models;


public class DirectoryModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    [Column("CREATION")] public DateTime Creación { get; set; }
    public DirectoryModel? Parent { get; set; }
    public int ParentId { get; set; }
    public IdentityModel Identity { get; set; } = null!;
    public int IdentityId { get; set; }
    public List<PolicyModel> Policies { get; set; } = [];
    public List<SecurityGroupModel> SecurityGroups { get; set; } = [];

}