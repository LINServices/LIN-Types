namespace LIN.Types.Developer.Models;

public class SubscriptionModel
{
    public int Id { get; set; }
    public int RenewalDays { get; set; }
    public decimal Amount { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public bool IsActive { get; set; }
    public bool IsAutomatic { get; set; }
    public ProjectDataModel Project { get; set; } = new();
    public int ProjectId { get; set; }
}