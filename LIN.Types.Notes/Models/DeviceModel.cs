using System.Diagnostics;

namespace LIN.Types.Notes.Models;

[DebuggerDisplay("Id:{Id} Platform:{Platform} LocalId:{LocalId}")]
public class DeviceModel
{
    public string Id { get; set; } = string.Empty;
    public string LocalId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Platform { get; set; } = string.Empty;
}