namespace LIN.Types.Identity.Models;


public class LoginLogModel
{

    public int ID { get; set; } = 0;

    [Column("FECHA")]
    public DateTime Date { get; set; }

   
    public LoginTypes Type { get; set; } = LoginTypes.Undefined;

    [Column("USUARIO_FK")]
    public int AccountID { get; set; } = 0;

    public AccountModel Account { get; set; }

    public ApplicationModel Application { get; set; } = new();


}