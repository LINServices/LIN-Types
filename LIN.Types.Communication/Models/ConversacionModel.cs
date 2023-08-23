namespace LIN.Types.Communication.Models;


public class ConversaciónModel
{
    public int ID { get; set; }
    public ProfileModel UsuarioA { get; set; }
    public ProfileModel UsuarioB { get; set; }
    public List<MessageModel> Mensajes { get; set; }
}
