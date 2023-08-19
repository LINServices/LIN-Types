namespace LIN.Types.Inventory.Models;


public class ProfileModel : IProfile
{

    public int ID { get; set; } = 0;
    public DateTime Creación { get; set; }
    public int AccountID { get; set; }
    public string Hash { get; set; } = string.Empty;

}
