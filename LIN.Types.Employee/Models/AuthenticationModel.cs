namespace LIN.Types.Employee.Models;


public class AuthenticationModel
{

    public ProfileDataModel Profile { get; set; } = new();

    public Auth.Models.AccountModel Account { get; set; } = new();

    public string AccountToken { get; set; } = string.Empty;

}