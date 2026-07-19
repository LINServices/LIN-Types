using System.ComponentModel.DataAnnotations;

namespace LIN.Cloud.Synapse.Types.Requests;

public class ChatMessage
{
    [Required]
    public string Role { get; set; } = string.Empty;

    [Required]
    public string Content { get; set; } = string.Empty;
}
