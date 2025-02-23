using LIN.Types.Communication.Enumerations;

namespace LIN.Types.Communication.Models;

public class ConversationModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<MemberChatModel> Members { get; set; } = new();
    public List<MessageModel> Mensajes { get; set; } = new();
    public ConversationsTypes Type { get; set; }
    public ConversationVisibility Visibility { get; set; }
}