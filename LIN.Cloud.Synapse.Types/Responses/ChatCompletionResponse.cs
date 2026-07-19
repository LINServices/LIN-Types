using LIN.Cloud.Synapse.Types.Requests;

namespace LIN.Cloud.Synapse.Types.Responses;

public class ChatCompletionResponse
{
    public string Id { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public ChatMessage Message { get; set; } = new();
    public string? FinishReason { get; set; }
    public UsageInfo Usage { get; set; } = new();
}
