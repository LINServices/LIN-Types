namespace LIN.Types.Developer.Models;

public class SubscriptionPayment
{
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string? Description { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public SubscriptionPaymentStatus Status { get; set; } = SubscriptionPaymentStatus.None;
    public SubscriptionModel Subscription { get; set; } = new();
    public int SubscriptionId { get; set; }
}