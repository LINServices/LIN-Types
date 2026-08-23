namespace LIN.Types.Cloud.Identity.Platform.Organizations;

public class Domain
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string VerificationCode { get; set; } = string.Empty;
    public bool IsVerified { get; set; }
    public int OrganizationId { get; set; }
    public Organization Organization { get; set; } = null!;
}
