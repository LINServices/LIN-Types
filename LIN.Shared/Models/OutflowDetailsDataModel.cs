using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Shared.Models
{
    public class OutflowDetailsDataModel : AbstractDetailsDataModel
    {

        [Column("SALIDA_FK")]
        public override int Movimiento { get; set; }

    }
}
