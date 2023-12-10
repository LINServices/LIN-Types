namespace LIN.Types.Identity.Models;


public class PolicyModel
{

    public int Id { get; set; }
    public PolicyTypes Type { get; set; }
    public DateTime Creation {  get; set; }
    public string ValueJson { get; set; } = string.Empty;

    public DirectoryModel Directory { get; set; } = null!;
    public int DirectoryId { get; set; }

}