namespace LIN.Types.Auth.Models;


public class LoginLogModel
{

    public int ID { get; set; } = 0;

    [Column("FECHA")]
    public DateTime Date { get; set; }

    [Column("PLATAFORMA")]
    public Platforms Platform { get; set; } = Platforms.Undefined;

    [Column("USUARIO_FK")]
    public int AccountID { get; set; } = 0;


}
