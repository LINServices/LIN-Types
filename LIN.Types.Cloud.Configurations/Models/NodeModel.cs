using System.Diagnostics;

namespace LIN.Types.Cloud.Configurations.Models;

[DebuggerDisplay("Node: {Id}, Key: {Key}, Value: {Value}")]
public class NodeModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
    public TenantModel TenantModel { get; set; }
    public int TenantModelId { get; set; }
}