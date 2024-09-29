namespace LIN.Types.Developer.Models;


public class FirewallRuleModel
{

    [Column("id")]
    public int ID { get; set; }

    [Column("name")]
    public string Name { get; set; } = string.Empty;

    [Column("start_ip")]
    public string IPInicio { get; set; } = string.Empty;

    [Column("end_ip")]
    public string IPFinal { get; set; } = string.Empty;

    [Column("state")]
    public FirewallRuleStatus Status { get; set; } = FirewallRuleStatus.Undefined;

    [Column("project_fk")]
    public int ProjectId { get; set; }

    public ProjectDataModel Project { get; set; } = null!;

}