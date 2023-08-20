namespace LIN.Types.Auth.Models;


public class AccountModel
{

    public int ID { get; set; } = 0;
    public string Usuario { get; set; } = string.Empty;
    public byte[] Perfil { get; set; } = Array.Empty<byte>();
    public string Nombre { get; set; } = string.Empty;

    [Column("CONTRASENA")]
    public string Contraseña { get; set; } = string.Empty;
    public Genders Genero { get; set; } = Genders.Undefined;
    [Column("CREACION")]
    public DateTime Creación { get; set; }
    public AccountStatus Estado { get; set; } = AccountStatus.Normal;
    public AccountRoles Rol { get; set; } = AccountRoles.User;
    public AccountVisibility Visibilidad { get; set; } = AccountVisibility.Visible;
    public AccountBadges Insignia { get; set; } = AccountBadges.None;
    public virtual OrganizationModel? Organization { get; set; }

}