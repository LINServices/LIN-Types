using System;
using System.Collections.Generic;
using System.Text;

namespace LIN.Types.Developer.Models.Tickets;

public class AgentMongoModel
{
    public int ProfileId { get; set; }

    public string Alias { get; set; } = string.Empty;
}
