namespace LIN.Types.Inventory.Models;

public class ProductDetailModel
{
    public int Id { get; set; } = 0;
    public decimal PurchasePrice { get; set; } = 0m;
    public decimal SalePrice { get; set; } = 0m;
    public int Quantity { get; set; } = 0;
    public ProductStatements Status { get; set; } = ProductStatements.Normal;
    public ProductModel Product { get; set; } = null!;
    public int ProductId { get; set; }
}