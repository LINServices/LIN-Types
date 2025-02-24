namespace LIN.Types.Developer.Projects;

public class PostgreSQLProject : Models.ProjectDataModel
{
    public string DatabaseName { get; set; } = string.Empty;
    public int DatabaseId { get; set; }
}