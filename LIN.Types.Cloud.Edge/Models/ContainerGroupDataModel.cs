namespace LIN.Types.Cloud.Edge.Models;

public class ContainerGroupDataModel
{
    public int Id { get; set; }
    public int ResourceId { get; set; }
    public string Metadata { get; set; } = string.Empty;
    public List<ContainerDataModel> Containers { get; set; } = [];
    public ServerDataModel Server { get; set; } = null!;
    public int ServerId { get; set; }
}