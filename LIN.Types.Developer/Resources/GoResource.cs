namespace LIN.Types.Developer.Resources;

public class GoResource : Models.ProjectDataModel
{
    public string Version { get; set; } = string.Empty;
    public bool AutoSwap { get; set; }
    public string Site { get; set; }
    public bool HttpEnable { get; set; }
    public GoGithubConfiguration? GithubConfiguration { get; set; }
}

public class GoGithubConfiguration
{
    public bool IsConfigured { get; set; }
    public string GitPath { get; set; }
    public string MainPackage { get; set; }
    public string Branch { get; set; }
}
