namespace LIN.Employee.Types.Models;


public class AuthenticationModel
{

    public ProfileDataModel Profile { get; set; } = new();

    public LIN.Types.Auth.Models.AccountModel Account { get; set; } = new();

    public string AccountToken { get; set; } = string.Empty;

}