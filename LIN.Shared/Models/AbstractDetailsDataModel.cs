using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Shared.Models
{
    public abstract class AbstractDetailsDataModel
{

    public int ID { get; set; } = 0;

    public int Cantidad { get; set; }

    [Column("PRODUCTO_DETAIL_FK")]
    public int ProductoDetail { get; set; }

    public abstract int Movimiento { get; set; }

}

}
