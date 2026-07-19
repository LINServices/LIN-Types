namespace LIN.Cloud.Synapse.Types.Responses;

public class UsageReportResponse
{
    public int ResourceId { get; set; }
    public DateTime From { get; set; }
    public DateTime To { get; set; }
    public List<UsageSummaryItem> Items { get; set; } = new();
    public long TotalRequestCount { get; set; }
    public long TotalInputTokens { get; set; }
    public long TotalOutputTokens { get; set; }
    public decimal TotalEstimatedCost { get; set; }
}
