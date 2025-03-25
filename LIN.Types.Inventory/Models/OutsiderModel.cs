namespace LIN.Types.Inventory.Models;

public class OutsiderModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Document { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public OutsiderTypes Type { get; set; }
    public InventoryDataModel InventoryDataModel { get; set; } = null!;
    public int InventoryId { get; set; }
}