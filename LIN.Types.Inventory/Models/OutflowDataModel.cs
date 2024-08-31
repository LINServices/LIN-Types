namespace LIN.Types.Inventory.Models
{
    public class OutflowDataModel : MovementDataModel<OutflowDetailsDataModel>
    {

        [Column("TIPO")]
        public OutflowsTypes Type { get; set; }


        [NotMapped]
        public decimal Ganancia { get; set; } = 0;


        [NotMapped]
        public decimal Utilidad { get; set; } = 0;



    }


}
