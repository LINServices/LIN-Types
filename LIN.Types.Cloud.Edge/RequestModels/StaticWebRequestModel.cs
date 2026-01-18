namespace LIN.Types.Cloud.Edge.RequestModels;

public class StaticWebRequestModel
{
    public string SiteName { get; set; }
    public StaticDeployConfig DeployConfig { get; set; }
}