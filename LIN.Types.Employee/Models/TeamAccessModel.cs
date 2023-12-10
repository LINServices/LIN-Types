using LIN.Types.Employee.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Types.Employee.Models;

public class TeamAccessModel
{

    public int ID { get; set; } = 0;
    public ProjectRoles Rol { get; set; }
    public DateTime Join { get; set; }
    public ProfileDataModel Profile { get; set; } = null!;
    public TeamDataModel Team { get; set; } = null!;


}
