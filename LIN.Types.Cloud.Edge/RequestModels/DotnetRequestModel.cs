namespace LIN.Types.Cloud.Edge.RequestModels;

public class DotnetRequestModel
{
    public string SiteName { get; set; }
    public DotnetDeployConfigRequest DotnetDeployConfigRequest { get; set; }
    public PlanConfigurationResource PlanConfiguration { get; set; }
}

public class NodeRequestModel
{
    public string SiteName { get; set; }
    public NodeDeployConfigRequest DeployConfigRequest { get; set; }
    public PlanConfigurationResource PlanConfiguration { get; set; }
}

public class PlanConfigurationResource
{
    public int ResourceBaseId { get; set; }
    public int Cpu { get; set; }
    public int Memory { get; set; }
}