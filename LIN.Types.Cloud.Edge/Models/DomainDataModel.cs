using LIN.Types.Cloud.Edge.Enums;

namespace LIN.Types.Cloud.Edge.Models;

public class DomainDataModel
{
    public int Id { get; set; }
    public string DomainCloudflareId { get; set; }
    public string DomainName { get; set; }
    public DomainStatus Status { get; set; }
    public DomainType Type { get; set; }
}