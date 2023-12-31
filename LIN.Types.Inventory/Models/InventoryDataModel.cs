﻿using LIN.Types.Inventory.Enumerations;
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
        public string Direccion { get; set; } = string.Empty;

        [Column("ULTIMAMOD")]
        public DateTime UltimaModificacion { get; set; }

        [Column("CREADOR_FK")]
        public int Creador { get; set; } = 0;

        [NotMapped]
        public InventoryRoles MyRol { get; set; }

        [NotMapped]
        public List<InventoryAcessDataModel> UsersAccess { get; set; } = new();


    }
}
