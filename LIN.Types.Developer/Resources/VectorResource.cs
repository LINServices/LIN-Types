namespace LIN.Types.Developer.Resources;

public class VectorResource : Models.ProjectDataModel
{
    public string EmbeddingModel { get; set; } = string.Empty;

    public int EmbeddingDimensions { get; set; }

    public int MaxDocuments { get; set; }

    public int RateLimitPerMinute { get; set; }
}