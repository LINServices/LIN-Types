namespace LIN.Types.Inventory.Models;

public class OutflowDetailsDataModel
{
    public int Id { get; set; } = 0;
    public int Quantity { get; set; }
    public ProductDetailModel ProductDetail { get; set; } = null!;
    public int ProductDetailId { get; set; }
    public OutflowDataModel Movement { get; set; } = null!;
    public int MovementId { get; set; }
}