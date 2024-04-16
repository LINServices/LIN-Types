namespace LIN.Types.Developer.Models;


public class TransactionDataModel
{

    [Column("ID")]
    public int ID { get; set; }

    [Column("DATE")]
    public DateTime Fecha { get; set; }

    [Column("DESCRIPTION")]
    public string Description { get; set; } = string.Empty;

    [Column("VALUE")]
    public decimal Valor { get; set; }

    [Column("TYPE")]
    public TransactionTypes Tipo { get; set; }

    [Column("BILLING_ITEM_FK")]
    public int BillingId { get; set; }

    [Column("PROFILE_ID")]
    public int ProfileID { get; set; }


    public BillingItemModel Billing { get; set; }
    public ProfileDataModel Profile { get; set; }

}