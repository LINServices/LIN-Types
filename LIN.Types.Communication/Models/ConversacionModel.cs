namespace LIN.Types.Communication.Models;


public class ConversationModel
{

    public List<ProfileModel> Members { get; set; }
    public List<MessageModel> Mensajes { get; set; }

    public int UsuarioAID { get; set; }
    public int UsuarioBID { get; set; }

}
