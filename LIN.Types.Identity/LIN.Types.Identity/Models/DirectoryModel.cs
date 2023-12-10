namespace LIN.Types.Identity.Models;


public class DirectoryModel
{

    public int ID { get; set; } = 0;
    public IdentityModel Identity { get; set; } = null!;
    public int IdentityId { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public List<DirectoryMember> Members { get; set; } = [];
    public List<PolicyModel> Policies { get; set; } = [];

    [Column("CREACION")]
    public DateTime Creación { get; set; }

}