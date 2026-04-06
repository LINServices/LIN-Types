namespace LIN.Types.Cloud.Edge.RequestModels;

public class PlanDtoModel
{
    public int ResourcePlanId { get; set; } 
    public int Cpu { get; set; }
    public int Memory { get; set; }
    public string RegionName { get; set; } = string.Empty;
    public string RegionCode { get; set; } = string.Empty;
}