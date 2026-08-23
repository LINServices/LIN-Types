namespace LIN.Types.Cloud.Identity.Platform.Identities;

public class LoginRequest
{
    public string Unique { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public Guid ApplicationKey { get; set; }

    /// <summary>
    /// Opcional solo si el usuario pertenece a 0 o 1 organizaciones; con 2 o más es obligatorio
    /// informarla (ver OrganizationResolutionStep).
    /// </summary>
    public int? OrganizationId { get; set; }
}
