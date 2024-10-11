namespace LIN.Types.Auth.Models;

public class AccountModel
{

    public int Id { get; set; } = 0;
    public string User { get; set; } = string.Empty;
    public byte[] Profile { get; set; } = [];
    public string Name { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public Genders Genero { get; set; } = Genders.Undefined;
    public DateTime Creation { get; set; }
    public DateTime? Birthday { get; set; }
    public AccountStatus Estado { get; set; } = AccountStatus.Normal;
    public AccountRoles Rol { get; set; } = AccountRoles.User;
    public AccountVisibility Visibilidad { get; set; } = AccountVisibility.Visible;
    public AccountBadges Insignia { get; set; } = AccountBadges.None;

    public OrganizationAccessModel? OrganizationAccess { get; set; }

}