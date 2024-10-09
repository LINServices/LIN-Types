namespace LIN.Types.CommerceMax.Models;

public class ProfileModel : IProfile
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public DateTime Creation { get; set; }
}