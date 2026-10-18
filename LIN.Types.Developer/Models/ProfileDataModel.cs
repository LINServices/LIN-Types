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

    [Column("first_name")]
    public string FirstName { get; set; } = string.Empty;

    [Column("last_name")]
    public string LastName { get; set; } = string.Empty;

    [Column("accept_updates")]
    public bool AcceptUpdates { get; set; } = true;

    [Column("share_partners")]
    public bool SharePartners { get; set; } = false;

    [Column("terms_accepted_at")]
    public DateTime? TermsAcceptedAt { get; set; }

}