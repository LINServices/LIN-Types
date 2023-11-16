namespace LIN.Types.Blogs.Models;


public class PublicationModel
{
    public int Id { get; set; }
    public string Content { get; set; }
    public string Tittle { get; set; }
    public BlogModel Blog { get; set; }
    public int BlogId { get; set; }
}
