namespace LIN.Types.Developer.Models;

public class ProjectDataModel
{

    [Column("pro_id")]
    public int Id { get; set; }

    [Column("pro_name")]
    public string Name { get; set; } = string.Empty;

    [Column("pro_creation")]
    public DateTime Creation { get; set; }

    [Column("pro_state")]
    public ProjectStatus Status { get; set; } = ProjectStatus.None;

    [Column("pro_type")]
    public string Type { get; set; } = string.Empty;

    [NotMapped]
    public bool IsProvisioned { get; set; }

    [Column("pro_visible_keys")]
    public bool VisibleKeys { get; set; }

    [Column("pro_visible_rules")]
    public bool VisibleRules { get; set; }
    public List<OwnerModel> Owners { get; set; } = [];
    public List<FirewallRuleModel> FirewallRules { get; set; } = [];
    public List<KeyModel> Keys { get; set; } = [];

    public List<TransactionDataModel> Transactions { get; set; } = [];

    public BillingAccount Billing { get; set; } = null!;
    public int BillingId { get; set; }

}