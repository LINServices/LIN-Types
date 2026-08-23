using LIN.Types.Cloud.Identity.Platform.Access.Enums;
using MongoDB.Bson.Serialization.Attributes;

namespace LIN.Types.Cloud.Identity.Platform.Access;

public class AccessPolicy
{
    [BsonId]
    public string Id { get; set; } = string.Empty;
    public int OrganizationId { get; set; }
    public string Name { get; set; } = string.Empty;
    public PolicyEffect Effect { get; set; }
    public List<TimeRule> TimeRules { get; set; } = [];
    public List<IdentityTypeRule> IdentityTypeRules { get; set; } = [];
    public List<NetworkRule> NetworkRules { get; set; } = [];
    public List<int> Identities { get; set; } = [];
    public List<int> Applications { get; set; } = [];
}
