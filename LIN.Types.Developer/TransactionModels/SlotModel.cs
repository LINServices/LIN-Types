namespace LIN.Types.Developer.TransactionModels;

public class SlotModel
{
    public int Id { get; set; }
    public string SiteName { get; set; } = string.Empty;
    public bool IsProduction { get; set; }
    public string Status { get; set; } = string.Empty;
    public SlotStatus State { get; set; }
    public List<string> CustomDomains { get; set; }  
}

public enum SlotStatus
{
    Unknown,
    Running,
    Stopped,
    Restarting
}