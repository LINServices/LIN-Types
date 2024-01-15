namespace LIN.Types.Cloud.Identity.Models;


public class OrganizationModel
{

    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DirectoryModel Directory { get; set; } = null!;
    public int DirectoryId { get; set; }
    public DateTime Creation {  get; set; }

}