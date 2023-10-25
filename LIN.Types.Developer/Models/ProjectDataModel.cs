namespace LIN.Types.Developer.Models;


public class ProjectDataModel
{

    public int ID { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public string ProjectUId { get; set; } = "";

    public DateTime Creation { get; set; }

    public ProfileDataModel Profile { get; set; }

    public ProjectStatus Estado { get; set; } = ProjectStatus.None;

}