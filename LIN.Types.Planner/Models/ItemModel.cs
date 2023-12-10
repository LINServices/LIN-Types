namespace LIN.Types.Planner.Models;


public class ItemModel
{

    public int Id { get; set; }
    public ProjectModel Project { get; set; } = null!;
    public bool IsDone { get; set; }
    public DateTime EndDate { get; set; }
    public ProfileModel? Executor { get; set; }

}
