using LIN.Shared.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Shared.Models;


/// <summary>
/// Model de 'UserAccessLogDataModel'
/// </summary>
public class UserAccessLogDataModel
{

    public int ID { get; set; } = 0;

    [Column("FECHA")]
    public DateTime Date { get; set; }

    [Column("PLATAFORMA")]
    public Platforms Platform { get; set; } = Platforms.Undefined;

    [Column("USUARIO_FK")]
    public int UserID { get; set; } = 0;


}
