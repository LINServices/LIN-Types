using LIN.Types.Communication.Enumerations;

namespace LIN.Types.Communication.Models;


public class ConversationModel
{

    public string Name { get; set; }
    public List<ProfileModel> Members { get; set; }
    public List<MessageModel> Mensajes { get; set; }
    public ConversationsTypes Type { get; set; }
}
