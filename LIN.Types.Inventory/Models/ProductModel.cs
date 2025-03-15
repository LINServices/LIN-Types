namespace LIN.Types.Inventory.Models;

public class ProductModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string Code { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public ProductCategories Category { get; set; } = ProductCategories.Undefined;
    public ProductBaseStatements Statement { get; set; }
    public InventoryDataModel Inventory { get; set; } = null!;
    public int InventoryId { get; set; }

    public List<ProductDetailModel> Details { get; set; } = [];

    [NotMapped]
    public ProductDetailModel? DetailModel => Details?.FirstOrDefault();

}