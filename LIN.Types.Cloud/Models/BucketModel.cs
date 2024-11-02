namespace LIN.Types.Cloud.Models;

public class BucketModel
{
    public int Id { get; set; }
    public long MaxSize { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}