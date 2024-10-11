namespace LIN.Types.Auth.Abstracts;

public class SessionModel<T> where T : new()
{

    public AccountModel Account { get; set; } = new();

    public T Profile { get; set; } = new();

}