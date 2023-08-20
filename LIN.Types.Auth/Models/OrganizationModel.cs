namespace LIN.Types.Auth.Models;


public class OrganizationModel
{

    public OrganizationModel()
    {
        //this.Members = new HashSet<AccountModel>();
        //this.AppList = new HashSet<AppOrganizationModel>();
    }

    public int ID { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string Domain { get; set; } = string.Empty;
    public List<AccountModel> Members { get; set; }
    public List<AppOrganizationModel> AppList { get; set; }

}