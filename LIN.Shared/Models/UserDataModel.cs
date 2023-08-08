using LIN.Shared.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Shared.Models
{

    /// <summary>
    /// Model de 'UserDataModel'
    /// </summary>
    public class UserDataModel
    {
       
        public int ID { get; set; } = 0;
        public string Usuario { get; set; } = string.Empty;
        public byte[] Perfil { get; set; } = Array.Empty<byte>();
        public string Nombre { get; set; } = string.Empty;

        [Column("CONTRASENA")]
        public string Contraseña { get; set; } = string.Empty;

        public Sexos Sexo { get; set; } = Sexos.Undefined;
        public DateTime Creacion { get; set; }
        public AccountStatus Estado { get; set; } = AccountStatus.Normal;
        public UserRol Rol { get; set; } = UserRol.User;
        public UserVisibility Visibilidad { get; set; } = UserVisibility.Visible;
        public Insignias Insignia { get; set; } = Insignias.None;


    }
}
