namespace LIN.Types.Cloud.Identity.Platform.Organizations;

public class TransitiveGroupMember
{
    public int IdentityId { get; set; }
    public int ViaGroupId { get; set; }
    public int Depth { get; set; }
}
