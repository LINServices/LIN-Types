namespace LIN.Types.Inventory.Models;

public class InflowDetailsDataModel
{
    public int Id { get; set; } = 0;
    public int Cantidad { get; set; }
    public ProductDetailModel ProductDetail { get; set; } = null!;
    public int ProductDetailId { get; set; }
    public InflowDataModel Movement { get; set; } = null!;
    public int MovementId { get; set; }
}