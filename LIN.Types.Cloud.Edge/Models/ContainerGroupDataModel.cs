namespace LIN.Types.Cloud.Edge.Models;

internal class ContainerGroupDataModel
{
    public int Id { get; set; }
    public int ResourceId { get; set; }
    public List<ContainerDataModel> Containers { get; set; } = [];
    public ServerDataModel Server { get; set; } = null!;
    public int ServerId { get; set; }
}