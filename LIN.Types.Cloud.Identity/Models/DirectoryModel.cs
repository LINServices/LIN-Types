namespace LIN.Types.Cloud.Identity.Models;


public class DirectoryModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public GroupModel Group { get; set; } = null!;
    public int GroupId { get; set; }

}