namespace LIN.Types.Cloud.Identity.Models;

public class DomainModel
{
    public int Id { get; set; }
    public string Domain { get; set; } = string.Empty;
    public bool IsVerified { get; set; }
    public OrganizationModel Organization { get; set; } = null!;
    public int OrganizationId { get; set; }
}