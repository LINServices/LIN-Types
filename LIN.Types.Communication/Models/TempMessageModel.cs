namespace LIN.Types.Communication.Models;

public class TempMessageModel
{
    public int Id { get; set; }
    public int Conversation { get; set; }
    public string Message { get; set; }
    public DateTime Time { get; set; }

}