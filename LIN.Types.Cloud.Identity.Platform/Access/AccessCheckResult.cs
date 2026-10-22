using System.Text.Json;

namespace LIN.Types.Cloud.Identity.Platform.Access;

public class AccessCheckResult
{
    public bool Allowed { get; set; }
    public List<string> Permissions { get; set; } = [];
    public JsonElement? Metadata { get; set; }
    public MetadataSource? MetadataSource { get; set; }
    public bool Degraded { get; set; }
}

public class MetadataSource
{
    public string GrantId { get; set; } = string.Empty;
    public int IdentityId { get; set; }
    public int Distance { get; set; }
    public bool Inherited => Distance > 0;
    public DateTime UpdatedAt { get; set; }
}
