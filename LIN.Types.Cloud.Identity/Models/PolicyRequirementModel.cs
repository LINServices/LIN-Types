namespace LIN.Types.Cloud.Identity.Models;

public class PolicyRequirementModel
{
    public int Id { get; set; }
    public PolicyRequirementTypes Type { get; set; }
    public string? Requirement { get; set; }
    public PolicyModel Policy { get; set; } = null!;
    public Guid PolicyId { get; set; }
}