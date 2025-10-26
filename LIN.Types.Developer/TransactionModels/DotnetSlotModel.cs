namespace LIN.Types.Developer.TransactionModels;

public class DotnetSlotModel
{
    public string SiteName { get; set; } = string.Empty;
    public bool IsProduction { get; set; }
    public string Status { get; set; } = string.Empty;

    public List<string> CustomDomains { get; set; }  
}