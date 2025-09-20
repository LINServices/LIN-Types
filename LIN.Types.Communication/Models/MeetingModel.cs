namespace LIN.Types.Communication.Models;

public class MeetingModel
{
    public int Id { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime? EndTime { get; set; }
    public List<MeetingMemberModel> Members { get; set; } = [];

    public int ConversationId { get; set; }
    public ConversationModel Conversation { get; set; }
}