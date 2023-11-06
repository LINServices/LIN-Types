namespace LIN.Types.Developer.Models;


public class KeyModel
{

    [Column("ID")]
    public int ID { get; set; }

    [Column("NAME")]
    public string Nombre { get; set; } = string.Empty;

    [Column("KEY")]
    public string Key { get; set; } = string.Empty;

    [Column("STATE")]
    public ApiKeyStatus Status { get; set; } = ApiKeyStatus.Actived;

    [Column("PROJECT_FK")]
    public int ProjectId { get; set; }


}