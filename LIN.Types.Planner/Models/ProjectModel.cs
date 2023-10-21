namespace LIN.Types.Planner.Models;


public class ProjectModel
{

    public int Id { get; set; } 
    public string Name { get; set; }
    public bool IsClose { get; set; }
    public List<ItemModel> Tasks { get; set; }
    public List<MemberModel> Members { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

}