namespace LIN.Types.Cloud.Identity.Models;

public class IdentityModel
{
    public int Id { get; set; }
    public string Unique { get; set; } = string.Empty;
    public DateTime CreationTime { get; set; }
    public DateTime? EffectiveTime { get; set; }
    public DateTime? ExpirationTime { get; set; }
    public IdentityStatus Status { get; set; }

}