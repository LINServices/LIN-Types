namespace LIN.Types.Developer.Models;


public class ProjectDataModel
{

    [Column("ID")]
    public int ID { get; set; }

    [Column("NAME")]
    public string Nombre { get; set; } = string.Empty;

    [Column("CREATION")]
    public DateTime Creation { get; set; }

    [Column("PROFILE_ID")]
    public int ProfileID { get; set; }

    [Column("STATE")]
    public ProjectStatus Estado { get; set; } = ProjectStatus.None;


    public List<FirewallRuleModel> FirewallRules { get; set; } = new();
    public List<KeyModel> Keys { get; set; } = new();

}