using LIN.Types.Inventory.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Types.Inventory.Models
{
    public class InflowDataModel : MovementDataModel<InflowDetailsDataModel>
    {

        [Column("TIPO")]
        public InflowsTypes Type { get; set; }

        [NotMapped]
        public decimal Prevision { get; set; }

    }


}
