using LIN.Types.Inventory.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Types.Inventory.Models;

public class ProductDetailDataModel
{

    public int ID { get; set; } = 0;

    [Column("PRECIO_COMPRA")]
    public decimal PrecioCompra { get; set; } = 0m;

    [Column("PRECIO_VENTA")]
    public decimal PrecioVenta { get; set; } = 0m;

    [Column("CANTIDAD")]
    public int Quantity { get; set; } = 0;

    [Column("ESTADO")]
    public ProductStatements Estado { get; set; } = ProductStatements.Normal;

    [Column("PRODUCTO_FK")]
    public int ProductoFK { get; set; } = 0;


    public ProductDetailDataModel Clone()
    {
        return new()
        {
            ID = ID,
            Estado = Estado,
            ProductoFK = ProductoFK,
            Quantity = Quantity,
            PrecioCompra = PrecioCompra,
            PrecioVenta = PrecioVenta
        };
    }

}
