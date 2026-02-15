namespace LIN.Types.Developer.Resources;

public class OcelotResource : Models.ProjectDataModel
{
    public string Site { get; set; }
    public List<string> CustomDomains { get; set; }
}