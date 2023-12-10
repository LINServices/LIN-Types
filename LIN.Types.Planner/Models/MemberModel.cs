namespace LIN.Types.Planner.Models;


public class MemberModel
{
    public int Id { get; set; }
    public ProfileModel Profile { get; set; } = null!;
    public ProjectModel Project { get; set; } = null!;
}
