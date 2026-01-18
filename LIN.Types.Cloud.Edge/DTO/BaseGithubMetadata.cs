namespace LIN.Types.Cloud.Edge.DTO;

public class BaseGithubMetadata
{
    public int GithubRegistryId { get; set; }
    public bool Enable { get; set; }
    public string GitUrl { get; set; } = string.Empty;
    public string Branch { get; set; } = string.Empty;
}