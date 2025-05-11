namespace LIN.Types.Cloud.Identity.Models.Policies;

public class TimeAccessPolicy
{
    public int Id { get; set; }
    public PolicyModel Policy { get; set; }
    public int PolicyId { get; set; }
    public TimeOnly StartHour { get; set; }
    public TimeOnly EndHour { get; set; }
}
