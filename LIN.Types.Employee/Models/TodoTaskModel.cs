namespace LIN.Types.Employee.Models;


public class TodoTaskModel
{

    public int ID { get; set; }
    public string Content { get; set; } = string.Empty;
    public bool IsDone { get; set; }
    public int ProfileCreator { get; set; }
    public int ProjectID { get; set; }

}
