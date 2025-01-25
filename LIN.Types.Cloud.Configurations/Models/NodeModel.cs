using System.Collections.Generic;
using System.Diagnostics;

namespace LIN.Types.Cloud.Configurations.Models;

[DebuggerDisplay("Node: {Id}, Name: {Name}, IsNode: {IsNode}")]
public class NodeModel
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public NodeModel NodeParent { get; set; }
    public int? NodeParentId { get; set; }
    public string Key { get; set; }
    public string Value { get; set; }
    public bool IsNode { get; set; }
    public TenantModel TenantModel { get; set; }
    public int TenantModelId { get; set; }
    public List<NodeModel> Childs { get; set; }
}