namespace LIN.Types.Cloud.Edge.Models;

public class ReleaseDataModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }
    public DateTime CreatedAt { get; set; }

    public int ContainerGroupId { get; set; }
    public ContainerGroupDataModel ContainerGroup { get; set; } = null!;
}