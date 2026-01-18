namespace LIN.Types.Developer.Models;

public class OwnerModel
{
    public ProfileDataModel Profile { get; set; } = null!;
    public ResourcePermission ResourcePermission { get; set; }
    public FinancePermission FinancePermission { get; set; }

    [Column("profile_id")]
    public int ProfileId { get; set; }
    public ProjectDataModel Project { get; set; } = null!;

    [Column("project_id")]
    public int ProjectId { get; set; }
}