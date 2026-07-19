namespace LIN.Cloud.Synapse.Types.Responses;

public class EmbeddingResponse
{
    public string Model { get; set; } = string.Empty;
    public List<List<float>> Embeddings { get; set; } = new();
    public UsageInfo Usage { get; set; } = new();
}
