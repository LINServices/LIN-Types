namespace LIN.Types.Inventory.Models;

public class InventoryDataModel
{
    public int Id { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string Direction { get; set; } = string.Empty;
    public int CreatorId { get; set; } = 0;
    public List<ProductModel> Products { get; set; } = [];
    public List<OutflowDataModel> Outflows { get; set; } = [];
    public List<InflowDataModel> Inflows { get; set; } = [];
    public virtual OpenStoreSettings? OpenStoreSettings { get; set; }
    public int? OpenStoreSettingsId { get; set; }

    [NotMapped]
    public InventoryRoles MyRol { get; set; }

    [NotMapped]
    public List<InventoryAccessDataModel> UsersAccess { get; set; } = new();

}