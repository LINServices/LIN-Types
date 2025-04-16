namespace LIN.Types.Developer.Projects;

public class MongoServerProject : Models.ProjectDataModel
{
    public string Host { get; set; } = string.Empty;
    public int MaxSize { get; set; }
    public int Port { get; set; }
    public bool IsRunning { get; set; }
    public string ServerStatus { get; set; } = string.Empty;
}