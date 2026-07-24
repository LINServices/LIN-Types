using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace LIN.Cloud.Synapse.Types.Requests;

public class ChatMessage
{
    /// <summary>"system", "user", "assistant" or "tool".</summary>
    [Required]
    public string Role { get; set; } = string.Empty;

    /// <summary>
    /// Null when an assistant message only carries <see cref="ToolCalls"/>. Every other
    /// role is expected to set it; that coherence is validated by the service rather than
    /// by an attribute, because whether it is required depends on the role.
    /// </summary>
    public string? Content { get; set; }

    /// <summary>
    /// Invocations requested by the model. Only meaningful on the "assistant" role.
    /// </summary>
    /// <remarks>
    /// Omitted when null so that responses to callers who never use tools stay byte
    /// identical to what they received before this field existed.
    /// </remarks>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<ToolCall>? ToolCalls { get; set; }

    /// <summary>
    /// Which invocation this message answers. Required on the "tool" role, and must match
    /// the <see cref="ToolCall.Id"/> of a preceding assistant message.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? ToolCallId { get; set; }
}
