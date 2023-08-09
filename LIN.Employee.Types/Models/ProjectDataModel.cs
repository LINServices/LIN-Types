using LIN.Employee.Types.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Employee.Types.Models;


/// <summary>
/// Modelo
/// </summary>
public class ProjectDataModel
{

    public int ID { get; set; } = 0;
    public string Nombre { get; set; } = string.Empty;
    public byte[] Image { get; set; } = Array.Empty<byte>();

    [Column("CREADOR_FK")]
    public int Creador { get; set; } = 0;

    [NotMapped]
    public ProjectRoles MyRol { get; set; }

    [NotMapped]
    public List<ProjectAcessDataModel> UsersAccess { get; set; } = new();


}
