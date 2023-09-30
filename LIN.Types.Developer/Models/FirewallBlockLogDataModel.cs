using LIN.Types.Developer.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Types.Developer.Models;


public class FirewallBlockLogDataModel
{

    [Column("ID")]
    public int ID { get; set; }

    [Column("IPv4")]
    public string IPv4 { get; set; } = string.Empty;

    [Column("PROYECTO_FK")]
    public int ProyectoID { get; set; }

    [Column("ESTADO")]
    public FirewallBlockStatus Estado { get; set; }
}