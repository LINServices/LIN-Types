namespace LIN.Types.Cloud.Identity.Models.Policies;

/// <summary>
/// Modelo de política de acceso para MongoDB.
/// </summary>
public class AccessPolicyModel
{
    public string Id { get; set; }

    /// <summary>
    /// Id de la organización.
    /// </summary>
    public int OrganizationId { get; set; }

    /// <summary>
    /// Nombre de la política.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Efecto por defecto si la política coincide.
    /// </summary>
    public PolicyEffect Effect { get; set; }

    /// <summary>
    /// Reglas de tiempo.
    /// </summary>
    public List<TimeRule> TimeRules { get; set; } = [];

    /// <summary>
    /// Reglas de tipo de identidad.
    /// </summary>
    public List<IdentityTypeRule> IdentityTypeRules { get; set; } = [];

    /// <summary>
    /// Reglas de red.
    /// </summary>
    public List<NetworkRule> NetworkRules { get; set; } = [];

    /// <summary>
    /// Lista de identidades que tienen aplicada la politica.
    /// </summary>
    public List<int> Identities { get; set; } = [];

    /// <summary>
    /// Lista de aplicaciones que tienen la politca.
    /// </summary>
    public List<int> Applications { get; set; } = [];
}