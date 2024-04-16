namespace LIN.Types.Developer.Models;


public class FirewallRuleModel
{

    [Column("ID")]
    public int ID { get; set; }

    [Column("NAME")]
    public string Name { get; set; } = string.Empty;

    [Column("STARTING_IP")]
    public string IPInicio { get; set; } = string.Empty;

    [Column("FINAL_IP")]
    public string IPFinal { get; set; } = string.Empty;

    [Column("STATE")]
    public FirewallRuleStatus Status { get; set; } = FirewallRuleStatus.Undefined;

    [Column("PROJECT_FK")]
    public int ProjectId { get; set; }


    public ProjectDataModel Project { get; set; } = null!;

}