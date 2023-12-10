using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Types.Inventory.Models
{
    public class InflowDetailsDataModel : AbstractDetailsDataModel
    {

        [Column("ENTRADA_FK")]
        public override int Movimiento { get; set; }


    }
}
