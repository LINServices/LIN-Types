using System.Diagnostics;

namespace LIN.Types.Cloud.Configurations.Models;

[DebuggerDisplay("Tenant: {Id}, Name: {Name}, Resource: {ProjectId}")]
public class TenantModel
{
    public int Id { get; set; }
    public int ProjectId { get; set; }
}