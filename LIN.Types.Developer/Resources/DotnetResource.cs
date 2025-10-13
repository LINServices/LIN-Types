namespace LIN.Types.Developer.Resources;

public class DotnetResource : DockerResource
{
    public string Version { get; set; } = string.Empty;
    public bool IsConfigured { get; set; }
    public string GitPath { get; set; }
    public string CSProj { get; set; }
    public string Site { get; set; }
}