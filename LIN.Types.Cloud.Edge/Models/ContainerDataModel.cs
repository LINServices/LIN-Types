using LIN.Types.Cloud.Edge.Enums;

namespace LIN.Types.Cloud.Edge.Models;

public class ContainerDataModel
{
    public int Id { get; set; }
    public string DockerContainerId { get; set; } = string.Empty;
    public ContainerTags Tag { get; set; }
    public ContainerStates InformationState { get; set; }
    public ContainerTypes Type { get; set; }
    public bool Autoscale { get; set; }
    public List<VolumeDataModel> Volumes { get; set; } = [];
    public List<BindingDataModel> Bindings { get; set; } = [];
    public List<DnsRegistryDataModel> DnsRegistries { get; set; } = [];
    public ContainerGroupDataModel ContainerGroup { get; set; } = null!;
    public int ContainerGroupId { get; set; }
    public ServerDataModel Server { get; set; } = null!;
    public int ServerId { get; set; }
}