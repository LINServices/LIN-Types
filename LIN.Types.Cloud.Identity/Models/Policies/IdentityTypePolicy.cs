namespace LIN.Types.Cloud.Identity.Models.Policies;

public class IdentityTypePolicy
{
    public int Id { get; set; }
    public PolicyModel Policy { get; set; }
    public int PolicyId { get; set; }
    public IdentityType Type { get; set; }
}
