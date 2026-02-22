namespace LIN.Types.Developer.Resources;

public class NodeResource : Models.ProjectDataModel
{
    public List<SlotModel> Slots { get; set; } = [];
    public List<SlotModel> Publishers { get; set; } = [];
    public string Version { get; set; } = string.Empty;
    public bool AutoSwap { get; set; }
    public string Site { get; set; }
    public bool HttpEnable { get; set; }
    public NodeGithubConfiguration? GithubConfiguration { get; set; }
}

public class NodeGithubConfiguration
{
    public bool IsConfigured { get; set; }
    public string GitPath { get; set; }
    public string Branch { get; set; }
    public string NpmBuildCommand { get; set; }
}