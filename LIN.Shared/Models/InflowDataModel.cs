using LIN.Shared.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Shared.Models
{
    public class InflowDataModel : MovementDataModel<InflowDetailsDataModel>
    {
       
        [Column("TIPO")]
        public InflowsTypes Type { get; set; }

    }


}
