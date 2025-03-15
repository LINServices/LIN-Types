namespace LIN.Types.Inventory.Models;

public class InventoryAccessDataModel
{
    public int Id { get; set; } = 0;
    public InventoryRoles Rol { get; set; }
    public InventoryAccessState State { get; set; }
    public DateTime Date { get; set; }
    public int ProfileId { get; set; }
    public int InventoryId { get; set; }
}