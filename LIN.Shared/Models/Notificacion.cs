
namespace LIN.Shared.Models;

public class Notificacion
{
    public int ID { get; set; } = 0;
    public string Inventario { get; set; } = string.Empty;
    public int InventarioID { get; set; } = 0;
    public string UsuarioInvitador { get; set; } = string.Empty;
    public DateTime Fecha { get; set; }

}
