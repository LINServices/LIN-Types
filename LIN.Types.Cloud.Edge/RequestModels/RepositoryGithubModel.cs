namespace LIN.Types.Cloud.Edge.RequestModels;

public sealed class RepoDto
{
    public string Nombre { get; set; } = default!;
    public string Owner { get; set; } = default!;
    public string Git { get; set; } = default!; // clone_url (termina en .git)
}
