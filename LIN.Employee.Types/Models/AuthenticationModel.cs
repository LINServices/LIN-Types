namespace LIN.Employee.Types.Models;


public class AuthenticationModel
{

    public ProfileDataModel Profile { get; set; } = new();

    public Shared.Models.UserDataModel Account { get; set; } = new();

    public string AccountToken { get; set; } = string.Empty;

}