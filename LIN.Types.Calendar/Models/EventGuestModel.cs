namespace LIN.Types.Calendar.Models;

public class EventGuestModel
{    
    public EventModel Event { get; set; } = null!;
    public ProfileModel Profile { get; set; } = null!;
    public int EventId { get; set; }
    public int ProfileId { get; set; }
}