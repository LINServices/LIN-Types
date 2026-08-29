using LIN.Types.Cloud.Identity.Platform.Identities;

namespace LIN.Types.Cloud.Identity.Platform.Abstracts;

public class SessionModel<T> where T : new()
{
    public Account Account { get; set; } = null!;
    public T Profile { get; set; } = new();
}