namespace LIN.Types.Blogs.Models;


public class PublicationModel
{
    public int Id { get; set; }
    public string Content { get; set; } = string.Empty;
    public string Tittle { get; set; } = string.Empty;
    public BlogModel Blog { get; set; } = null!;
    public int BlogId { get; set; }
}
