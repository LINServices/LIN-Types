using LIN.Types.Developer.BillingModels;

namespace LIN.Types.Developer.TransactionModels;

public class InvoiceDto
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime PendingToPayDate { get; set; }
    public DateTime OverdueTime { get; set; }
    public decimal? Price { get; set; }
    public InvoiceStatus Status { get; set; }
}