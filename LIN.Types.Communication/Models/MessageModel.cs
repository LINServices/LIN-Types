namespace LIN.Types.Communication.Models;


public class MessageModel
{
    public int ID { get; set; }
    public ConversaciónModel Conversacion { get; set; }
    public string Contenido { get; set; }
    public DateTime Time { get; set; }
}
