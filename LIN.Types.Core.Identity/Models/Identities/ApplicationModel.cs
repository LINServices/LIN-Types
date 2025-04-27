namespace LIN.Types.Core.Identity.Models.Identities;

public class ApplicationModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public IdentityModel Identity { get; set; } = null!;
    public int IdentityId { get; set; }
    public Guid Key { get; set; }
    public IdentityModel Owner { get; set; } = null!;
    public int OwnerId { get; set; }
}