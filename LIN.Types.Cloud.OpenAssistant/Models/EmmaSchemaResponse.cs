using System.Collections.Generic;

namespace LIN.Types.Cloud.OpenAssistant.Models;

public class EmmaSchemaResponse
{
    public string UserText { get; set; }
    public List<string> Commands { get; set; }
    public List<string> Actions { get; set; }
    public bool RequireApp { get; set; }
}