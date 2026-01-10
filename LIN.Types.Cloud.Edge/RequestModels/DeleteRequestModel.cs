namespace LIN.Types.Cloud.Edge.RequestModels;

public class DeleteRequestModel
{
    public int ResourceId { get; set; }
    public string TokenCloud { get; set; } = string.Empty;
}