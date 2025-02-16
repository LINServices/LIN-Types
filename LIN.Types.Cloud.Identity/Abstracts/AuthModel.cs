using LIN.Types.Cloud.Identity.Models;

namespace LIN.Types.Cloud.Identity.Abstracts;

public class AuthModel<T> where T : new()
{
    public AccountModel Account { get; set; } = null!;
    public T Profile { get; set; } = default!;
    public Dictionary<string, string> TokenCollection { get; set; } = null!;
}