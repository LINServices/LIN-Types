namespace LIN.Types.Employee.Models;


/// <summary>
/// Modelo
/// </summary>
public class TeamDataModel
{

    public int ID { get; set; } = 0;
    public string Nombre { get; set; } = string.Empty;
    public int OrganizationID { get; set; }
    public List<TeamAccessModel> TeamMates { get; set; } = new();

}
