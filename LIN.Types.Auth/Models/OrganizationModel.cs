namespace LIN.Types.Auth.Models;


public class OrganizationModel
{

    public int ID { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string Domain { get; set; } = string.Empty;
    public ICollection<AccountModel> Members { get; set; }
    public ICollection<AppOrganizationModel> AppList { get; set; }

}