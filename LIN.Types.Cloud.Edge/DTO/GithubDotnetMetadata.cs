namespace LIN.Types.Cloud.Edge.DTO;

public class GithubDotnetMetadata : BaseGithubMetadata
{
    public string CSProj { get; set; } = string.Empty;
}

public class GithubStaticMetadata : BaseGithubMetadata
{
    public string NpmBuildCommand { get; set; } = string.Empty;
    public string BuildPath { get; set; } = string.Empty;
}

public class GithubNodeMetadata : BaseGithubMetadata
{
    public string NpmBuildCommand { get; set; } = string.Empty;
}