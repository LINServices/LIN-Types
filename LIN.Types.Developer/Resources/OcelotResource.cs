namespace LIN.Types.Developer.Resources;

public class OcelotResource : Models.ProjectDataModel
{
    public int ContainerId { get; set; }
    public string Site { get; set; }
    public List<string> CustomDomains { get; set; }
}