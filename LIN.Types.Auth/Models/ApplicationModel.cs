namespace LIN.Types.Auth.Models;


public class ApplicationModel
{

    public int ID { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string Key { get; set; } = string.Empty;

    public OrganizationModel Organization { get; set; } = new();

}