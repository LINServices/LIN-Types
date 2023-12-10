namespace LIN.Types.CommerceMax.Models;


public class ProfileModel : IProfile
{

    public int ID { get; set; }

    public int AccountID { get; set; }
    public DateTime Creation { get; set; }
}
