namespace LIN.Types.Notes.Models;

public class ProfileModel : IProfile
{

    public int Id { get; set; } = 0;
    public DateTime Creation { get; set; }
    public int AccountId { get; set; }

}