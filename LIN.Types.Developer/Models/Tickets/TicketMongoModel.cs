using LIN.Types.Developer.Enumerations.Tickets;

namespace LIN.Types.Developer.Models.Tickets;

public class TicketMongoModel
{
    public string Id { get; set; } 

    public int ProjectId { get; set; }

    public int ProfileId { get; set; }
    public int AgentProfileId { get; set; }

    public bool IsAttendingIa { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public DateTime Creation { get; set; }

    public TicketStatus Status { get; set; }

    public TicketPriority Priority { get; set; }

    public List<TicketEvent> Events { get; set; } = new();
}