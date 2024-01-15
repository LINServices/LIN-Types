namespace LIN.Types.Identity.Models;


public class AccountModel
{

    public int ID { get; set; } = 0;
    public IdentityModel Identity { get; set; } = null!;
    public byte[] Perfil { get; set; } = [];
    public string Nombre { get; set; } = string.Empty;

    [Column("CONTRASENA")] public string Contraseña { get; set; } = string.Empty;

    [Column("CREACION")] public DateTime Creación { get; set; }
    public DateTime? Birthday { get; set; }
    public AccountStatus Estado { get; set; } = AccountStatus.Normal;
    public AccountVisibility Visibilidad { get; set; } = AccountVisibility.Visible;
    public AccountBadges Insignia { get; set; } = AccountBadges.None;
    public Genders Gender { get; set; } = Genders.Undefined;
    public int IdentityId { get; set; }

    public List<SecurityGroupModel> SecurityGroups { get; set; }

}