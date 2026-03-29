namespace LIN.Types.Developer.Models;

public class NotificationModel
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Content { get; set; } = string.Empty;
    public bool IsRead { get; set; } 
    public DateTime CreatedAt { get; set; }
    public DateTime? ReadAt { get; set; }
    public ProfileDataModel Profile { get; set; } = default!;
    public int ProfileId { get; set; }
}