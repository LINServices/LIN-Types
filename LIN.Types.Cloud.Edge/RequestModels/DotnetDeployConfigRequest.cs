namespace LIN.Types.Cloud.Edge.RequestModels;

public class DotnetDeployConfigRequest
{
    public string RepositoryUrl { get; set; }
    public string CsProjReference { get; set; }
    public string Branch { get; set; }
    public string Version { get; set; }
    public bool EnableMultiStaging { get; set; }
}

public class StaticDeployConfigRequest
{
    public string RepositoryUrl { get; set; }
    public string NpmCommand { get; set; }
    public string BuildPath { get; set; }
    public string Branch { get; set; }
    public bool UseNpm { get; set; }
    public bool EnableMultiStaging { get; set; }
}