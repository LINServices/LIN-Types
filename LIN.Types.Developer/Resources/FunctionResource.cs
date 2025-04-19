namespace LIN.Types.Developer.Resources;

public class FunctionResource : Models.ProjectDataModel
{
    public string GeneralPath { get; set; } = string.Empty;
    public List<string> Endpoints { get; set; } = [];
}