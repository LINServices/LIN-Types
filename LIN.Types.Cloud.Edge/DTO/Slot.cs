using LIN.Types.Cloud.Edge.Enums;

namespace LIN.Types.Cloud.Edge.DTO;

public class SlotModel
{
    public int Id { get; set; }
    public string SiteName { get; set; } = string.Empty;
    public bool IsProduction { get; set; }
    public string Status { get; set; } = string.Empty;
    public SlotStatus State { get; set; }
    public List<string> CustomDomains { get; set; }
    public SlotRelease? LastRelease { get; set; }
    public ContainerTypes Type { get; set; }
}

public enum SlotStatus
{
    Unknown,
    Running,
    Stopped,
    Restarting
}

public class SlotRelease
{
    public int ReleaseId { get; set; }
    public string ReleaseName { get; set; }
}