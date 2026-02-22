namespace LIN.Types.Cloud.Edge.DTO;

public abstract class ResourceMetadata
{
    public bool AutoSwap { get; set; }
    public bool HttpPublish { get; set; }
    public abstract BaseGithubMetadata? GithubMetadataBase { get; }
}

public class ResourceMetadata<TGithub> : ResourceMetadata where TGithub : BaseGithubMetadata
{
    public TGithub? GithubMetadata { get; set; }
    public override BaseGithubMetadata? GithubMetadataBase => GithubMetadata;
}

public class DotnetMetadata : ResourceMetadata<GithubDotnetMetadata>
{
    public string Version { get; set; } = string.Empty;
}

public class StaticMetadata : ResourceMetadata<GithubStaticMetadata>
{
    public bool UseNpm { get; set; }
}

public class NodeMetadata : ResourceMetadata<GithubNodeMetadata>
{
    public string Version { get; set; } = string.Empty;
}