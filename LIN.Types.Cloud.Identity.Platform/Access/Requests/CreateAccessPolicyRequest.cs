using LIN.Types.Cloud.Identity.Platform.Access.Enums;

namespace LIN.Types.Cloud.Identity.Platform.Access.Requests;

public record CreateAccessPolicyRequest(
    int OrganizationId,
    string Name,
    PolicyEffect Effect,
    List<TimeRule> TimeRules,
    List<IdentityTypeRule> IdentityTypeRules,
    List<NetworkRule> NetworkRules,
    List<int> Identities,
    List<int> Applications);
