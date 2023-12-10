using LIN.Types.Inventory.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Types.Inventory.Models
{
    public class OutflowDataModel : MovementDataModel<OutflowDetailsDataModel>
    {

        [Column("TIPO")]
        public OutflowsTypes Type { get; set; }

    }


}
