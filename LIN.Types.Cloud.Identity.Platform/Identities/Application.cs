using LIN.Types.Cloud.Identity.Platform.Identities.Enums;

namespace LIN.Types.Cloud.Identity.Platform.Identities;

/// <summary>
/// Tiene dos relaciones distintas con <see cref="Identity"/>: la propia (<see cref="IdentityId"/>,
/// de tipo <see cref="IdentityType.Service"/>) y la de su dueño (<see cref="OwnerIdentityId"/>).
/// </summary>
public class Application
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Guid Key { get; set; }
    public int IdentityId { get; set; }
    public Identity Identity { get; set; } = null!;
    public int OwnerIdentityId { get; set; }
    public Identity Owner { get; set; } = null!;
}
