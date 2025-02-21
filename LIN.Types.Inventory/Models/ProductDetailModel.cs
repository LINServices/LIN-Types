namespace LIN.Types.Inventory.Models;

public class ProductDetailModel
{
    public int Id { get; set; } = 0;

    [Column("PRECIO_COMPRA")]
    public decimal PrecioCompra { get; set; } = 0m;

    [Column("PRECIO_VENTA")]
    public decimal PrecioVenta { get; set; } = 0m;

    [Column("CANTIDAD")]
    public int Quantity { get; set; } = 0;

    [Column("ESTADO")]
    public ProductStatements Estado { get; set; } = ProductStatements.Normal;

    public ProductModel Product { get; set; } = null!;

    public int ProductId { get; set; }

}