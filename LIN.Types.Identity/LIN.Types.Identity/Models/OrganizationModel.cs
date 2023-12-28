namespace LIN.Types.Identity.Models;


public class OrganizationModel
{

    public int ID { get; set; } = 0;
    public bool IsPublic { get; set; }
    public string Name { get; set; } = string.Empty;
    public DirectoryModel Directory { get; set; } = null!;
    public int DirectoryId { get; set; }

}