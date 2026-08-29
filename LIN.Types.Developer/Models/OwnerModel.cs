namespace LIN.Types.Developer.Models;

[Obsolete("This model is deprecated and will be removed in future versions.")]
public class OwnerModel
{
    public ProfileDataModel Profile { get; set; } = null!;

    public int ProfileId { get; set; }
    public ProjectDataModel Project { get; set; } = null!;

    public int ProjectId { get; set; }
}