using LIN.Types.Communication.Enumerations;

namespace LIN.Types.Communication.Models;


public class MemberChatModel
{
    public ProfileModel Profile { get; set; }

    public MemberRoles Rol { get; set; }

    public ConversationModel Conversation { get; set; }

}
