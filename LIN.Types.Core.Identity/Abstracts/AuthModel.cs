using LIN.Types.Core.Identity.Models.Identities;

namespace LIN.Types.Core.Identity.Abstracts;

public class AuthModel<T> where T : new()
{
    public AccountModel Account { get; set; } = null!;
    public T Profile { get; set; } = default!;
    public Dictionary<string, string> TokenCollection { get; set; } = null!;
}