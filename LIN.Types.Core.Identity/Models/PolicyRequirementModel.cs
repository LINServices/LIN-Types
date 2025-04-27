using LIN.Types.Core.Identity.Enumerations;

namespace LIN.Types.Core.Identity.Models;

public class PolicyRequirementModel
{
    public int Id { get; set; }
    public PolicyRequirementTypes Type { get; set; }
    public string? Requirement { get; set; }
    public PolicyModel Policy { get; set; } = null!;
    public Guid PolicyId { get; set; }
}