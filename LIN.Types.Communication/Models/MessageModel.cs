using LIN.Types.Communication.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Types.Communication.Models;

public class MessageModel
{
    public int Id { get; set; }
    public string Contenido { get; set; }
    public MessageTypes Type { get; set; }
    public DateTime Time { get; set; }
    public ConversationModel Conversacion { get; set; }
    public ProfileModel? Remitente { get; set; }

    [NotMapped]
    public string Guid { get; set; }

    [NotMapped]
    public bool IsLocal { get; set; }

}
