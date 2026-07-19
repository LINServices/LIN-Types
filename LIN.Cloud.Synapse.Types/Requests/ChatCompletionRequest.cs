using System.ComponentModel.DataAnnotations;

namespace LIN.Cloud.Synapse.Types.Requests;

public class ChatCompletionRequest
{
    [Required]
    public string Model { get; set; } = string.Empty;

    [Required]
    [MinLength(1)]
    public List<ChatMessage> Messages { get; set; } = new();

    public int? MaxTokens { get; set; }

    public double? Temperature { get; set; }
}
