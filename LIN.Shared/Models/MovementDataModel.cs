﻿using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Shared.Models
{

    public abstract class MovementDataModel<DetailsModel> where DetailsModel : class 
    {

        public int ID { get; set; } = 0;


        [Column("FECHA")]
        public DateTime Date { get; set; }


        [Column("INVENTARIO_FK")]
        public int Inventario { get; set; }


        [Column("USUARIO_FK")]
        public int Usuario { get; set; }


        [NotMapped]
        public List<DetailsModel> Details { get; set; } = new();


        [NotMapped]
        public int CountDetails { get; set; } = 0;

        [NotMapped]
        public decimal Inversion { get; set; } = 0;



    }


}
