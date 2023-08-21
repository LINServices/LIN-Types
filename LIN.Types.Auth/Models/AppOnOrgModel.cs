namespace LIN.Types.Auth.Models;


public class AppOnOrgModel
{

    public int ID { get; set; } = 0;
    public AppOnOrgStates State { get; set; } = AppOnOrgStates.Activated;
    public virtual ApplicationModel App { get; set; }

}