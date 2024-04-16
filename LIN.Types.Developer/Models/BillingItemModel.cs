namespace LIN.Types.Developer.Models;


public class BillingItemModel
{

    [Column("ID")]
    public int ID { get; set; }

    [Column("KEY_FK")]
    public int KeyId { get; set; }

    [Column("TRANSACTION_FK")]
    public int TransactionId { get; set; }

    public TransactionDataModel Transaction { get; set; } = null!;
    public KeyModel Key { get; set; } = null!;


}