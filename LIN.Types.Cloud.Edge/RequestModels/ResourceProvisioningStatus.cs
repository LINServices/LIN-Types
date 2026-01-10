namespace LIN.Types.Cloud.Edge.RequestModels;

public class ResourceProvisioningStatus
{
    public int Resource { get; set; }
    public string Message { get; set; }
    public bool ShouldRetryLater { get; set; }
}