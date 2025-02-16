namespace LIN.Types.Cloud.Identity.Models;

public class ApplicationRestrictionTime
{
    public int Id { get; set; }
    public TimeSpan StartTime { get; set; }
    public TimeSpan EndTime { get; set; }
    public ApplicationRestrictionModel ApplicationRestrictionModel { get; set; } = null!;
    public int ApplicationRestrictionId { get; set; }
}