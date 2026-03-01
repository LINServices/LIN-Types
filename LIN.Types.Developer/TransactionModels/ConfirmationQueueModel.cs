using LIN.Types.Developer.BillingModels;

namespace LIN.Types.Developer.TransactionModels;

public class ConfirmationQueueModel
{
    public int ResourceId { get; set; }
    public decimal Amount { get; set; }
    public SubscriptionType Type { get; set; }
    public BillingUnit Unit { get; set; }
}