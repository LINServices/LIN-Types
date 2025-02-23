namespace LIN.Types.Developer.Models;

public class BillingAccount
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public BillingAccountTypes Type { get; set; }
    public BillingAccountStatus State { get; set; }
    public decimal Balance { get; set; }
    public List<TransactionDataModel> Transactions { get; set; } = [];
}