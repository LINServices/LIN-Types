namespace LIN.Types.Identity.Models;


public class IdentityModel
{

    public int Id { get; set; }
    public string Unique { get; set; } = string.Empty;
    public IdentityTypes Type { get; set; }

}