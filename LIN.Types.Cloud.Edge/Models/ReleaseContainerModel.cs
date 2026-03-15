namespace LIN.Types.Cloud.Edge.Models;

public class ReleaseContainerModel
{
    public int ReleaseId { get; set; }
    public int ContainerId { get; set; }
    public DateTime DateTime { get; set; }

    public ReleaseDataModel Release { get; set; } = null!;
    public ContainerDataModel Container { get; set; } = null!;
}