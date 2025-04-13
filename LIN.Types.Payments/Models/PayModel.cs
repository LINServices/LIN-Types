using LIN.Types.Payments.Enums;

namespace LIN.Types.Payments.Models;

public class PayModel
{
    public int Id { get; set; }
    public long ExternalId { get; set; }
    public int OrderId { get; set; }
    public decimal Amount { get; set; }
    public PayStatusEnum Status { get; set; }
    public string PaymentType { get; set; } = string.Empty;
    public string ExternalReference { get; set; } = string.Empty;
}