namespace LIN.Types.Calendar.Models;


public class EventModel
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public DateTime DateStart { get; set; }
    public DateTime EndStart { get; set; }
    public ProfileModel Creador { get; set; } = null!;
    public List<ProfileModel> Guests { get; set; } = [];

}