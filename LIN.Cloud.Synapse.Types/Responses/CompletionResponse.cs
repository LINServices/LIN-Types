namespace LIN.Cloud.Synapse.Types.Responses;

public class CompletionResponse
{
    public string Id { get; set; } = string.Empty;
    public string Model { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public string? FinishReason { get; set; }
    public UsageInfo Usage { get; set; } = new();
}
