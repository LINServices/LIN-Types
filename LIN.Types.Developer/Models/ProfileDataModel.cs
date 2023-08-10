using LIN.Types.Developer.Enumerations;

namespace LIN.Types.Developer.Models;


public class ProfileDataModel
{

    public int ID { get; set; }

    public string Name { get; set; } = string.Empty;

    public decimal Credito { get; set; } = 0m;

    public int Discont { get; set; } = 0;

    public string Email { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;

    public int UserID { get; set; }

    public ProfileStatus Estado { get; set; } = ProfileStatus.Normal;

}
