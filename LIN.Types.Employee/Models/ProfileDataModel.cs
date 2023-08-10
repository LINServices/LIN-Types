using LIN.Types.Employee.Enumerations;

namespace LIN.Types.Employee.Models;


/// <summary>
/// Modelo
/// </summary>
public class ProfileDataModel
{

    public int ID { get; set; } = 0;
    public DateTime Creacion { get; set; }
    public ProfileStatus Estado { get; set; } = ProfileStatus.Normal;

    public int AccountID { get; set; } = 0;
}
