namespace LIN.Types.Cloud.Models;

public class BucketIdentityModel
{
    public int Id { get; set; }
    public int IdentityId { get; set; }
    public BucketModel BucketModel { get; set; }
    public int BucketId { get; set; }
}