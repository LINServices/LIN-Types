namespace LIN.Types.Cloud.Identity.Platform.Access;

public class AccessSource
{
    public AccessSourceKind Kind { get; set; }
    public int? GroupId { get; set; }
}

public enum AccessSourceKind
{
    Direct = 1,
    Group = 2
}
