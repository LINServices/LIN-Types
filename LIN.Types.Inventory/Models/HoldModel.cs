namespace LIN.Types.Inventory.Models;

public class HoldModel
{
    public int Id { get; set; }
    public HoldStatus Status { get; set; }
    public int Quantity { get; set; }
    public ProductDetailModel DetailModel { get; set; } = null!;
    public int DetailId { get; set; }
    public HoldGroupModel GroupModel { get; set; } = null!;
    public int GroupId { get; set; }
}