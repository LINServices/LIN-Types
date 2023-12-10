using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Types.Communication.Models;


public class MessageModel
{ 
    public int ID { get; set; }
    public ConversationModel Conversacion { get; set; }
    public ProfileModel Remitente { get; set; }
    public string Contenido { get; set; }
    public DateTime Time { get; set; }

    [NotMapped]
    public string Guid { get; set; }


    [NotMapped]
    public bool IsLocal { get; set; } 

}
