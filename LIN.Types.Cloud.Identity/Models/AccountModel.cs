namespace LIN.Types.Cloud.Identity.Models;

public class AccountModel
{

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public byte[] Profile { get; set; } = [];
    public string Password { get; set; } = string.Empty;
    public DateTime Creation { get; set; }
    public IdentityService IdentityService { get; set; }
    public IdentityModel Identity { get; set; } = null!;
    public int IdentityId { get; set; }

}