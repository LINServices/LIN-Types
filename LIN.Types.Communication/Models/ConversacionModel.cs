using LIN.Types.Communication.Enumerations;

namespace LIN.Types.Communication.Models;


public class ConversationModel
{

    public int ID { get; set; }
    public string Name { get; set; }
    public List<MemberChatModel> Members { get; set; }
    public List<MessageModel> Mensajes { get; set; }
    public ConversationsTypes Type { get; set; }

}
