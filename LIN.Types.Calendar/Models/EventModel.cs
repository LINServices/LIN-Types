namespace LIN.Types.Calendar.Models;


public class EventModel
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public DateTime DateStart { get; set; }
    public DateTime EndStart { get; set; }
    public ProfileModel Profile { get; set; }

}