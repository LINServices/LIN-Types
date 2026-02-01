namespace LIN.Types.Cloud.Identity.Models.Policies;

/// <summary>
/// Regla basada en el tipo de identidad.
/// </summary>
public record IdentityTypeRule
{
    /// <summary>
    /// Tipos de identidad permitidos.
    /// </summary>
    public List<IdentityType> AllowedTypes { get; set; } = [];
}
