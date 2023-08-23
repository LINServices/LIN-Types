using LIN.Types.Employee.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Types.Employee.Models;

public class TeamAccessModel
{

    public int ID { get; set; } = 0;
    public ProjectRoles Rol { get; set; }
    public DateTime Join { get; set; }
    public virtual ProfileDataModel Profile { get; set; }
    public virtual TeamDataModel Team { get; set; }

}
