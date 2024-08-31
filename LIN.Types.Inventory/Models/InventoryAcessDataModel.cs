namespace LIN.Types.Inventory.Models
{
    public class InventoryAcessDataModel
    {


        public int ID { get; set; } = 0;
        public InventoryRoles Rol { get; set; }

        [Column("ESTADO")]
        public InventoryAccessState State { get; set; }

        public DateTime Fecha { get; set; }


        [Column("PROFILE_FK")]
        public int ProfileID { get; set; }


        [Column("INVENTARIO_FK")]
        public int Inventario { get; set; }





    }
}
