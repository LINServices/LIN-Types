namespace LIN.Types.Cloud.Edge.Models;

public class ContainerDataModel
{
    public int Id { get; set; }
    public string DockerContainerId { get; set; } = string.Empty;
    public string Metadata { get; set; } = string.Empty;
    public List<BindingDataModel> Bindings { get; set; } = [];
    public List<DnsRegistryDataModel> DnsRegistries { get; set; } = [];
}