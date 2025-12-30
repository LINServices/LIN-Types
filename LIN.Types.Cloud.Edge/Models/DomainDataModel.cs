namespace LIN.Types.Cloud.Edge.Models;

public class DomainDataModel
{
    public int Id { get; set; }
    public string DomainCloudflareId { get; set; }
    public string DomainName { get; set; }
    public DomainStatus Status { get; set; }
    public DomainType Type { get; set; }
}

public enum DomainStatus
{
    Inactive,
    Active
}

public enum DomainType
{
    ForSites,
    ForPublishing
}