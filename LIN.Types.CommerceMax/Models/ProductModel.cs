using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Types.CommerceMax.Models;


public class ProductModel
{

    public int ID { get; set; } = 0;

    [Column("PRECIO")]
    public decimal Precio { get; set; } = 0m;

    [Column("CANTIDAD")]
    public int Quantity { get; set; } = 0;

    [Column("ESTADO")]
    public Enumerations.ProductStatements Estado { get; set; } = Enumerations.ProductStatements.Normal;

    [Column("PROFILE_FK")]
    public int ProfileID { get; set; } = 0;

    [Column("IMAGEN")]
    public byte[] Image { get; set; } = Array.Empty<byte>();

    [Column("NOMBRE")]
    public string Name { get; set; } = string.Empty;

    [Column("DESCRIPCION")]
    public string Description { get; set; } = string.Empty;

}
