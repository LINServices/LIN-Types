namespace LIN.Types.Inventory.Models
{

    public abstract class MovementDataModel<DetailsModel> where DetailsModel : class
    {

        public int ID { get; set; } = 0;


        [Column("FECHA")]
        public DateTime Date { get; set; }

        public InventoryDataModel Inventory { get; set; } = null!;
        public int InventoryId { get; set; }


        [Column("PROFILE_FK")]
        public int ProfileID { get; set; }


        public List<DetailsModel> Details { get; set; } = [];




        [NotMapped]
        public int CountDetails { get; set; } = 0;

        [NotMapped]
        public decimal Inversion { get; set; } = 0;



    }


}
