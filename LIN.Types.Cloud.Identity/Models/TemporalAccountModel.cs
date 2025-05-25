namespace LIN.Types.Cloud.Identity.Models;

public class TemporalAccountModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string VerificationCode { get; set; } = string.Empty;
    public IdentityService Provider { get; set; }
    public int OrganizationId { get; set; }
}