namespace LIN.Types.Cloud.Edge.RequestModels;

public class StaticDeployConfig
{
    public string RepositoryUrl { get; set; }
    public string Branch { get; set; }
    public bool EnableMultiStaging { get; set; }
}