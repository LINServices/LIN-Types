namespace LIN.Types.Identity.Models;


public class ApplicationModel
{
    public int ID { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string ApplicationUid { get; set; } = string.Empty;
    public string Key { get; set; } = string.Empty;
    public ApplicationBadges Badge { get; set; } = ApplicationBadges.None;
    public int AccountID { get; set; }
    public DirectoryModel? Directory { get; set; }
    public int DirectoryId { get; set; }

}