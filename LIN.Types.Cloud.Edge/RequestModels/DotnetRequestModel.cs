namespace LIN.Types.Cloud.Edge.RequestModels;

public class DotnetRequestModel
{
    public string SiteName { get; set; }
    public DotnetDeployConfigRequest DotnetDeployConfigRequest { get; set; }
}

public class NodeRequestModel
{
    public string SiteName { get; set; }
    public NodeDeployConfigRequest DeployConfigRequest { get; set; }
}