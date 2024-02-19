using LIN.Types.Inventory.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Types.Inventory.Models
{

    /// <summary>
    /// Model de 'UserDataModel'
    /// </summary>
    public class InventoryDataModel
    {

        public int ID { get; set; } = 0;
        public string Nombre { get; set; } = string.Empty;
        public string Direction { get; set; } = string.Empty;


        [Column("CREADOR_FK")]
        public int Creador { get; set; } = 0;

        public List<ProductModel> Products { get; set; } = [];
        public List<OutflowDataModel> Outflows { get; set; } = [];
        public List<InflowDataModel> Inflows { get; set; } = [];



        [NotMapped]
        public InventoryRoles MyRol { get; set; }

        [NotMapped]
        public List<InventoryAcessDataModel> UsersAccess { get; set; } = new();


    }
}
