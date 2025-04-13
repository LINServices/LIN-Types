namespace LIN.Types.Payments.Models;

public class PaymentItemRequestModel
{
    public int Id { get; set; }
    public int Quantity { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Picture { get; set; } = string.Empty;
    public decimal Price { get; set; }
}