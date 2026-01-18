namespace LIN.Types.Developer.Models;

public class BillingAccessModel
{
    public int Id { get; set; }
    public BillingAccount BillingAccount { get; set; }
    public ProfileDataModel Profile { get; set; }
    public int BillingAccountId { get; set; }
    public int ProfileId { get; set; }
}