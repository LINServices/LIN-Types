namespace LIN.Types.Developer.Models;


public class ProfileDataModel : IProfile
{

    [Column("ID")]
    public int Id { get; set; }

    [Column("ALIAS")]
    public string Alias { get; set; } = string.Empty;

    [Column("CREDITS")]
    public decimal Credits { get; set; } = 0m;

    [Column("DISCOUNT")]
    public int Discount { get; set; } = 0;

    [Column("MAIL")]
    public string Email { get; set; } = string.Empty;

    [Column("DESCRIPTION")]
    public string Description { get; set; } = string.Empty;

    [Column("STATE")]
    public ProfileStatus Estado { get; set; } = ProfileStatus.Normal;

    [Column("CREATION")]
    public DateTime Creation { get; set; }

    [Column("ACCOUNT_ID")]
    public int AccountId { get; set; }

    public List<TransactionDataModel> Transactions { get; set; } = new();

}