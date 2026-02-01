namespace LIN.Types.Cloud.Identity.Models.Identities;

public class ApplicationModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Guid Key { get; set; }
    public IdentityModel Identity { get; set; } = null!;
    public int IdentityId { get; set; }
    public IdentityModel Owner { get; set; } = null!;
    public int OwnerId { get; set; }
}