namespace LIN.Types.Auth.Abstracts;


public class AuthModel<T> where T : new()
{

    public AccountModel Account { get; set; } = new();

    public T Profile { get; set; } = new();

    public string LINAuthToken { get; set; } = string.Empty;

}