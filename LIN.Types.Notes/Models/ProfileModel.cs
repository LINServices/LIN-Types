namespace LIN.Types.Notes.Models;


public class ProfileModel : IProfile
{

    public int ID { get; set; } = 0;
    public DateTime Creation { get; set; }
    public int AccountID { get; set; }

}