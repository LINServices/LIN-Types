namespace LIN.Types.Cloud.Edge.DTO;

public class MetadataDotnet
{
    public int Id { get; set; }
    public string Version { get; set; } = string.Empty;
    public bool AutoSwap { get; set; }
    public bool HttpPublish { get; set; }
    public GithubMetadata? GithubMetadata { get; set; }
}

public class GithubMetadata
{
    public int GithubRegistryId { get; set; }
    public bool Enable { get; set; }
    public string CSProj { get; set; } = string.Empty;
    public string GitUrl { get; set; } = string.Empty;
    public string Branch { get; set; } = string.Empty;
}