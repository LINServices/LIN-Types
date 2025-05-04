namespace LIN.Types.Cloud.Edge.RequestModels;

public class RequestDelete
{
    public int ResourceId { get; set; }
    public string TokenCloud { get; set; } = string.Empty;
}