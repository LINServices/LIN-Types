using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

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

    /// <summary>
    /// Tools the model may invoke. Requires a model with <c>ModelCapability.ToolUse</c>.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<ToolDefinition>? Tools { get; set; }

    /// <summary>
    /// "auto" (default), "none" or "required". Forcing one specific function is not
    /// supported yet.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ToolChoice { get; set; }
}
