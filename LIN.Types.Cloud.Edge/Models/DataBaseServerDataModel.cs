namespace LIN.Types.Cloud.Edge.Models;

public class DataBaseServerDataModel
{
    public int Id { get; set; }
    public int ResourceId { get; set; }
    public int Port { get; set; }
    public string ContainerId { get; set; }

    public EdgeNodeDataModel Node { get; set; } = new();
    public int NodeId { get; set; } = new();
}