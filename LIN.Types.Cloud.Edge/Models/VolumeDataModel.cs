namespace LIN.Types.Cloud.Edge.Models;

public class VolumeDataModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public ContainerDataModel Container { get; set; }
    public int ContainerId { get; set; }
}