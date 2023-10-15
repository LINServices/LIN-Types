namespace LIN.Types.Planner.Models;


public class WorkModel
{

    public int Id { get; set; }
    public ProjectModel Project { get; set; }
    public bool IsDone { get; set; }
    public DateTime EndDate { get; set; }
    public ProfileModel? Executor { get; set; }

}
