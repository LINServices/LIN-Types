namespace LIN.Types.Communication.Models;


public class MessageModel
{ 
    public int ID { get; set; }
    public ConversationModel Conversacion { get; set; }
    public ProfileModel Remitente { get; set; }
    public string Contenido { get; set; }
    public DateTime Time { get; set; }
}
