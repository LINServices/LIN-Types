using LIN.Shared.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Shared.Models
{
    public class OutflowDataModel : MovementDataModel<OutflowDetailsDataModel>
    {

        [Column("TIPO")]
        public OutflowsTypes Type { get; set; }

    }


}
