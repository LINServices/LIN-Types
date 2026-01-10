namespace LIN.Types.Cloud.Edge.DTO;

public class MetadataDotnet
{
    public int Id { get; set; }
    public string Version { get; set; } = string.Empty;
    public bool AutoSwap { get; set; }
    public bool HttpPublish { get; set; }
    public GithubMetadata? GithubMetadata { get; set; }
}