namespace LIN.Types.Developer.Models;

public class TransactionDataModel
{

    [Column("tra_id")]
    public int Id { get; set; }

    [Column("tra_date")]
    public DateTime Date { get; set; }

    [Column("tra_description")]
    public string Description { get; set; } = string.Empty;

    [Column("tra_value")]
    public decimal Valor { get; set; }

    [Column("tra_type")]
    public TransactionTypes Tipo { get; set; }

    [Column("tra_project_fk")]
    public int? ProjectId { get; set; }
    public ProjectDataModel? Project { get; set; } = null!;

    [Column("tra_billing_fk")]
    public int BillingId { get; set; }
    public BillingAccount Billing { get; set; } = null!;

}