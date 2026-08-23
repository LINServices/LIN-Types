using LIN.Types.Cloud.Identity.Platform.Access.Enums;

namespace LIN.Types.Cloud.Identity.Platform.Access;

/// <summary>
/// Resultado de evaluar un <see cref="PolicyValidationContext"/> contra las políticas
/// candidatas de la organización. Trae la traza completa (cierre de identidad usado, políticas
/// consideradas y cuál decidió) para que quien llama pueda auditar por qué se permitió o negó.
/// Clase (no record) porque <see cref="Types.Responses.ReadOneResponse{M}"/> exige un
/// constructor público sin parámetros en su tipo genérico.
/// </summary>
public class PolicyValidationResult
{
    public PolicyValidationResult()
    {
    }

    public PolicyValidationResult(
        bool allowed,
        string reason,
        List<int> consideredIdentityIds,
        List<string> consideredPolicyIds,
        string? decidingPolicyId,
        PolicyEffect? decidingEffect)
    {
        Allowed = allowed;
        Reason = reason;
        ConsideredIdentityIds = consideredIdentityIds;
        ConsideredPolicyIds = consideredPolicyIds;
        DecidingPolicyId = decidingPolicyId;
        DecidingEffect = decidingEffect;
    }

    public bool Allowed { get; set; }
    public string Reason { get; set; } = string.Empty;
    public List<int> ConsideredIdentityIds { get; set; } = [];
    public List<string> ConsideredPolicyIds { get; set; } = [];
    public string? DecidingPolicyId { get; set; }
    public PolicyEffect? DecidingEffect { get; set; }
}
