using LIN.Types.Developer.BillingModels;

namespace LIN.Types.Developer.TransactionModels;

public class InvoiceDto
{
    public int Id { get; set; }
    public int? SubscriptionId { get; set; }
    public DateTime RecollectTime { get; set; }
    public decimal? Price { get; set; }
    public InvoiceStatus Status { get; set; }
}