namespace LIN.Types.Cloud.Edge.Models;

public class ContainerGroupDataModel
{
    public int Id { get; set; }
    public int ResourceId { get; set; }
    public string Metadata { get; set; } = string.Empty;
    public ServerDataModel? ProxyServer { get; set; } = null!;
    public int? ProxyServerId { get; set; }
    public List<ContainerDataModel> Containers { get; set; } = [];
    public int? RegionId { get; set; }
    public RegionDataModel? Region { get; set; }
}