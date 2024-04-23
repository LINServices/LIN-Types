using LIN.Types.Calendar.Enumerations;

namespace LIN.Types.Calendar.Models;


public class EventModel
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public DateTime DateStart { get; set; }
    public DateTime EndStart { get; set; }
    public List<EventGuestModel> Guests { get; set; } = [];
    public EventTypes Type { get; set; }
    public bool IsAllDay { get; set; }

}