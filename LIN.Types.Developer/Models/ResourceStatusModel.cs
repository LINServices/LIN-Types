namespace LIN.Types.Developer.Models;

public class ResourceStatusModel
{
    public int Id { get; set; }
    public string Message { get; set; } = string.Empty;
    public DateTime DateTime { get; set; }
    public bool BeRetryLater { get; set; }

    public ProjectDataModel ProjectDataModel { get; set; }
    public int ProjectId { get; set; }
}