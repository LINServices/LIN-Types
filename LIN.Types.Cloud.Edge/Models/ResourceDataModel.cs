using System.Collections.Generic;

namespace LIN.Types.Cloud.Edge.Models;

public class ResourceDataModel
{
    public int Id { get; set; }
    public int ResourceId { get; set; }
    public string ContainerId { get; set; } = string.Empty;
    public List<BindingDataModel> Bindings { get; set; } = new();
    public EdgeNodeDataModel Node { get; set; } = new();
    public int NodeId { get; set; } = new();
}