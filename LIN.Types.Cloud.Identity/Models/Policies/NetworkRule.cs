namespace LIN.Types.Cloud.Identity.Models.Policies;

/// <summary>
/// Regla basada en la red (IP y País).
/// </summary>
public record NetworkRule
{
    /// <summary>
    /// IPs permitidas (Soporta CIDR).
    /// </summary>
    public List<string> IPWhitelist { get; set; } = [];

    /// <summary>
    /// IPs bloqueadas (Soporta CIDR).
    /// </summary>
    public List<string> IPBlacklist { get; set; } = [];

    /// <summary>
    /// Códigos de país permitidos (ISO 3166-1 alpha-2).
    /// </summary>
    public List<string> AllowedCountries { get; set; } = [];
}
