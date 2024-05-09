namespace LIN.Types.Notes.Transient;


public class Notification
{

    public int ID { get; set; } = 0;
    public string NoteName { get; set; } = string.Empty;
    public int NoteId { get; set; } = 0;
    public string UsuarioInvitador { get; set; } = string.Empty;
    public DateTime Fecha { get; set; }

}
