using LIN.Types.Developer.Enumerations.Tickets;
using LIN.Types.Developer.Models.Tickets;

namespace LIN.Types.Developer.TransactionModels.Tickets;

public class TicketDetailDto
{
    public string Id { get; set; } = string.Empty;

    public int ProjectId { get; set; }

    public int ProfileId { get; set; }

    public string Title { get; set; } = string.Empty;

    public string Content { get; set; } = string.Empty;

    public DateTime Creation { get; set; }

    public TicketPriority Priority { get; set; }

    public TicketStatus Status { get; set; }

    public List<TicketEvent> Events { get; set; } = new();

    public int? AgentId { get; set; }

    public string? AgentAlias { get; set; }
}