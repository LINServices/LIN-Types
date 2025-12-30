namespace LIN.Types.Cloud.Edge.Models;

public class DnsRegistryDataModel
{
    public int Id { get; set; }
    public string SiteName { get; set; }
    public string SiteId { get; set; }
    public DomainDataModel Domain { get; set; } = null!;
    public int DomainId { get; set; }
    public ContainerDataModel Container { get; set; } = null!;
    public int ContainerId { get; set; }
}