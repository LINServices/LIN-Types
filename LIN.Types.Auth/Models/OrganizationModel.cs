namespace LIN.Types.Auth.Models;


public class OrganizationModel
{

    public int ID { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string Domain { get; set; } = string.Empty;
    public List<AccountModel> Members { get; set; } = new();
    public List<ApplicationModel> WhiteList { get; set; } = new();

}