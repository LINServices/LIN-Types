using System.Reflection.Emit;

namespace LIN.Types.Identity.Models;


public class OrganizationModel
{

    public int ID { get; set; } = 0;
    public bool IsPublic { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Domain { get; set; } = string.Empty;
    public List<OrganizationAccessModel> Members { get; set; } = new();

    public DirectoryModel Directory { get; set; }
    public int DirectoryId { get; set; }

}