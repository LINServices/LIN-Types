using LIN.Types.Cloud.Edge.Enums;

namespace LIN.Types.Cloud.Edge.Models;

public class GroupScaleDataModel
{
    public int Id { get; set; }
    public int ScaleCount { get; set; }
    public ContainerTags Tags { get; set; }
    public int ContainerGroupId { get; set; }
    public ContainerGroupDataModel ContainerGroup { get; set; } = null!;
}