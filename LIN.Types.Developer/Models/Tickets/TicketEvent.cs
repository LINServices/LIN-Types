using LIN.Types.Developer.Enumerations.Tickets;
using System;
using System.Collections.Generic;
using System.Text;

namespace LIN.Types.Developer.Models.Tickets;

public class TicketEvent
{
    public string Id { get; set; }

    public TicketEventType Type { get; set; }

    public string Message { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }
}
