using LIN.Shared.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Shared.Models
{
    public class InventoryAcessDataModel
    {


        public int ID { get; set; } = 0;
        public InventoryRols Rol { get; set; } 

        [Column("ESTADO")]
        public InventoryAccessState State { get; set; }

        public DateTime Fecha { get; set; }


        [Column("USUARIO_FK")]
        public int Usuario { get; set; }

        [Column("INVENTARIO_FK")]
        public int Inventario { get; set; }





    }
}
