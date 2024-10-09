namespace LIN.Types.Developer.Models;


public class ProjectDataModel
{

    [Column("ID")]
    public int Id { get; set; }

    [Column("NAME")]
    public string Name { get; set; } = string.Empty;

    [Column("CREATION")]
    public DateTime Creation { get; set; }

    [Column("PROFILE_ID")]
    public int ProfileID { get; set; }

    [Column("STATE")]
    public ProjectStatus Status { get; set; } = ProjectStatus.None;


    public ProfileDataModel Profile { get; set; } = null!;
    public List<FirewallRuleModel> FirewallRules { get; set; } = [];
    public List<KeyModel> Keys { get; set; } = [];

}