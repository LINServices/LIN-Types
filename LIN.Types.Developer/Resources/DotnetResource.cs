namespace LIN.Types.Developer.Resources;

public class DotnetResource : Models.ProjectDataModel
{
    public List<DotnetSlotModel> Slots { get; set; } = [];
    public List<DotnetSlotModel> Publishers { get; set; } = [];
    public string Version { get; set; } = string.Empty;
    public bool AutoSwap { get; set; }
    public string Site { get; set; }
    public bool HttpEnable { get; set; }
    public DotnetGithubConfiguration? GithubConfiguration { get; set; }
}

public class DotnetGithubConfiguration
{
    public bool IsConfigured { get; set; }
    public string GitPath { get; set; }
    public string CSProj { get; set; }
    public string Branch { get; set; }
}