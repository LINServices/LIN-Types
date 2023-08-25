namespace LIN.Types.Auth.Models;


public class AppOnOrgModel
{

    public int ID { get; set; } = 0;
    public AppOnOrgStates State { get; set; } = AppOnOrgStates.Activated;
    public virtual ApplicationModel App { get; set; }
    public virtual OrganizationModel Organization { get; set; }


    public int AppID { get; set; } = 0;
    public int OrgID { get; set; } = 0;

}