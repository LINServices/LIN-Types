namespace LIN.Types.Developer.Models;


public class ProjectDataModel
{

    public int ID { get; set; }

    public string Nombre { get; set; } = string.Empty;

    public DateTime Creacion { get; set; }

    public ProfileDataModel Profile { get; set; }

    public ProjectStatus Estado { get; set; } = ProjectStatus.None;

    public List<FirewallRuleDataModel> IPs { get; set; } = new();

    public List<ApiKeyDataModel> Keys { get; set; } = new();


}