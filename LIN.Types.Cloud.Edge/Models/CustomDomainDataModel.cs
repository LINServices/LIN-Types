using LIN.Types.Cloud.Edge.Enums;

namespace LIN.Types.Cloud.Edge.Models;

public class CustomDomainDataModel
{
    public int Id { get; set; }
    public string SiteUrl { get; set; }
    public ContainerTags Tag { get; set; }
    public int ContainerGroupId { get; set; }
    public ContainerGroupDataModel ContainerGroup { get; set; }
}