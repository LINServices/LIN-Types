namespace LIN.Types.Developer.Projects;

public class BucketProject : Models.ProjectDataModel
{
    public int BucketId { get; set; }
    public double BucketSize { get; set; }
    public double BucketActualSize { get; set; }
}