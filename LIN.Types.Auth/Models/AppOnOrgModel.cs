namespace LIN.Types.Auth.Models;


public class AppOnOrgModel
{

    public int ID { get; set; } = 0;
    public AppOnOrgStates State { get; set; } = AppOnOrgStates.Activated;
    public virtual ApplicationModel App { get; set; } = new();
    public virtual OrganizationModel Organization { get; set; } = new();
    public int AppID { get; set; } = 0;
    public int OrgID { get; set; } = 0;

}