namespace LIN.Types.Auth.Models;


public class OrganizationModel
{

    public int ID { get; set; } = 0;
    public bool HaveWhiteList { get; set; }
    public bool LoginAccess { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Domain { get; set; } = string.Empty;
    public List<OrganizationAccessModel> Members { get; set; }
    public List<AppOnOrgModel> AppList { get; set; }
   // public OrgPolicy Policy { get; set; } = new();

}