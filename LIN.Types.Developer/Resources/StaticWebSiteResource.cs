namespace LIN.Types.Developer.Resources;

public class StaticWebSiteResource : Models.ProjectDataModel
{
    public List<SlotModel> Slots { get; set; } = [];
    public List<SlotModel> Publishers { get; set; } = [];
    public bool AutoSwap { get; set; }
    public string Site { get; set; }
    public bool HttpEnable { get; set; }
    public StaticGithubConfiguration? GithubConfiguration { get; set; }
}

public class StaticGithubConfiguration
{
    public bool IsConfigured { get; set; }
    public string GitPath { get; set; }
    public string Branch { get; set; }
}