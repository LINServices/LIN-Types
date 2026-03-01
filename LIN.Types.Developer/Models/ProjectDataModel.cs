namespace LIN.Types.Developer.Models;

public class ProjectDataModel
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public string Name { get; set; } = string.Empty;

    [Column("creation")]
    public DateTime Creation { get; set; }

    [Column("state")]
    public ProjectStatus Status { get; set; } = ProjectStatus.None;

    [Column("type")]
    public string Type { get; set; } = string.Empty;

    [Column("visibleKeys")]
    public bool VisibleKeys { get; set; }
    public bool IsConfirmed { get; set; }

    [Column("visibleRules")]
    public bool VisibleRules { get; set; }

    [Column("baseProject")]
    public int? baseProject { get; set; }

    [Column("subscription")]
    public int? Subscription { get; set; }

    public List<OwnerModel> Owners { get; set; } = [];
    public List<FirewallRuleModel> FirewallRules { get; set; } = [];
    public List<KeyModel> Keys { get; set; } = [];
    public List<TransactionDataModel> Transactions { get; set; } = [];
    public BillingAccount Billing { get; set; } = null!;
    public List<ResourceStatusModel> AprovisioneStatus { get; set; } = [];
    public int BillingId { get; set; }

    [NotMapped]
    public bool IsProvisioned { get; set; }

}