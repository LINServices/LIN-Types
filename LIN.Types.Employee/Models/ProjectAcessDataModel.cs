using LIN.Types.Employee.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Types.Employee.Models;

public class ProjectAcessDataModel
{


    public int ID { get; set; } = 0;
    public ProjectRoles Rol { get; set; }

    [Column("ESTADO")]
    public ProjectAccessState State { get; set; }

    public DateTime Fecha { get; set; }


    [Column("PROFILE_FK")]
    public int ProfileID { get; set; }

    [Column("PROJECT_FK")]
    public int ProjectID { get; set; }





}
