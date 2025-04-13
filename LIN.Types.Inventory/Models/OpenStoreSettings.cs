namespace LIN.Types.Inventory.Models;

public class OpenStoreSettings
{
    public int Id { get; set; }
    public bool IsActive { get; set; }
    public bool IsActiveOnlinePayments { get; set; }
    public string ApiKey { get; set; } = string.Empty;
    public InventoryDataModel InventoryDataModel { get; set; } = null!;
    public int InventoryId { get; set; }

}