using LIN.Employee.Types.Enumerations;

namespace LIN.Employee.Types.Models;

public class InternalDataModel
{

    public int InternalID { get; set; }
    public int AccesoID { get; set; }
    public int ProjectID { get; set; }
    public ProjectRoles Rol { get; set; }

}
