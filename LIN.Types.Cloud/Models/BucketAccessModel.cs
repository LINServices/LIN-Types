namespace LIN.Types.Cloud.Models;

public class BucketAccessModel
{
    public int Id { get; set; }
    public string Key { get; set; } = string.Empty;
    public int BucketId { get; set; }
    public BucketModel Bucket { get; set; }
}