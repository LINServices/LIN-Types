namespace LIN.Types.Cloud.Edge.Models;

public class BindingDataModel
{
    public int Id { get; set; }
    public int Port { get; set; }
    public string Name { get; set; } = string.Empty;
    public ResourceDataModel Resource { get; set; } = null!;
    public int ResourceId { get; set; }
}