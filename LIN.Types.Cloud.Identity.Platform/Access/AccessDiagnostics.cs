using LIN.Types.Cloud.Identity.Platform.Access.Enums;

namespace LIN.Types.Cloud.Identity.Platform.Access;

public class AccessDiagnosticsReport
{
    public int IdentityId { get; set; }
    public DateTime GeneratedAt { get; set; }
    public bool Degraded { get; set; }
    public bool Truncated { get; set; }
    public List<AccessDiagnosticFinding> Findings { get; set; } = [];
}

public class AccessDiagnosticFinding
{
    public string Code { get; set; } = string.Empty;
    public DiagnosticSeverity Severity { get; set; }
    public string? ObjectId { get; set; }
    public string? GrantId { get; set; }
    public List<int> IdentityIds { get; set; } = [];
    public string Message { get; set; } = string.Empty;
}
