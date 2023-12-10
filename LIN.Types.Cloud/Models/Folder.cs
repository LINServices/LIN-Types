namespace LIN.Types.Cloud.Models;


public class Folder
{

    public string Name { get; set; } = string.Empty;
    public List<Folder> Folders { get; set; } = [];
    public List<Files> Files { get; set; } = [];


}
