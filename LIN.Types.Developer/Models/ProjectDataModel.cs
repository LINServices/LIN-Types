using LIN.Types.Developer.Enumerations;

namespace LIN.Types.Developer.Models;


public class ProjectDataModel
{

    public int ID { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public DateTime Creacion { get; set; }

    public int ProfileID { get; set; }

    public ProjectStatus Estado { get; set; } = ProjectStatus.None;

    [NotMapped]
    public List<FirewallRuleDataModel> IPs { get; set; } = new();


}
