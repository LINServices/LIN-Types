namespace LIN.Types.Cloud.Identity.Models.Policies;

public class IpAccessPolicy
{
    public int Id { get; set; }
    public PolicyModel Policy { get; set; } = null!;
    public int PolicyId { get; set; }
    public string StartIp { get; set; } = string.Empty;
    public string EndIp { get; set; } = string.Empty;
}