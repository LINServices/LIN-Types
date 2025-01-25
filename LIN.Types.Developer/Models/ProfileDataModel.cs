namespace LIN.Types.Developer.Models;

public class ProfileDataModel : IProfile
{

    [Column("id")]
    public int Id { get; set; }

    [Column("alias")]
    public string Alias { get; set; } = string.Empty;

    [Column("discount")]
    public int Discount { get; set; } = 0;

    [Column("mail")]
    public string Email { get; set; } = string.Empty;

    [Column("description")]
    public string Description { get; set; } = string.Empty;

    [Column("state")]
    public ProfileStatus Estado { get; set; } = ProfileStatus.Normal;

    [Column("creation")]
    public DateTime Creation { get; set; }

    [Column("account_id")]
    public int AccountId { get; set; }

    public BillingAccount Billing { get; set; } = null!;
    public int BillingId { get; set; }

    public List<OwnerModel> MyProjects { get; set; } = [];

}