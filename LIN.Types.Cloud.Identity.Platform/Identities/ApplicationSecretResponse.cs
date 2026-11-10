namespace LIN.Types.Cloud.Identity.Platform.Identities;

/// <summary>
/// El secreto en claro solo se devuelve al generarlo o rotarlo; después únicamente queda su hash.
/// </summary>
public class ApplicationSecretResponse
{
    public Guid Key { get; set; }

    public string Secret { get; set; } = string.Empty;

    public DateTime CreatedAt { get; set; }
}
