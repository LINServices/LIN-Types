namespace LIN.Types.Auth.Models;


public class AppAccessModel
{

    public int ID { get; set; } = 0;
    public virtual ApplicationModel App { get; set; } = new();
    public virtual AccountModel Account { get; set; } = new();
    public int AppID { get; set; } = 0;
    public int AccountID { get; set; } = 0;

}