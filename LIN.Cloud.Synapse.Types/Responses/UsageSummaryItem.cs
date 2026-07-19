namespace LIN.Cloud.Synapse.Types.Responses;

public class UsageSummaryItem
{
    public string ModelId { get; set; } = string.Empty;
    public long RequestCount { get; set; }
    public long InputTokens { get; set; }
    public long OutputTokens { get; set; }
    public decimal EstimatedCost { get; set; }
}
