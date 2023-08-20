namespace LIN.Types.Auth.Models;


public class AppOrganizationModel
{

    public int ID { get; set; } = 0;
    public bool Estado { get; set; }
    public ApplicationModel App { get; set; } = new();

}