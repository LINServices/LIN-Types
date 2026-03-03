using LIN.Types.Developer.Models;

namespace LIN.Types.Developer.Resources;

public class PlanResource : ProjectDataModel
{
    public int MaxCpu { get; set; }
    public int Ping { get; set; }
    public int MaxMemory { get; set; }
    public int UsedCpu { get; set; }
    public int UsedMemory { get; set; }
}