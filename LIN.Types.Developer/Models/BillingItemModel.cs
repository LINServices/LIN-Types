namespace LIN.Types.Developer.Models;


public class BillingItemModel
{

    [Column("ID")]
    public int ID { get; set; }

    [Column("TRANSACTION_FK")]
    public int TransactionId { get; set; }

    public TransactionDataModel Transaction { get; set; } = null!;

}