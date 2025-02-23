namespace LIN.Types.Communication.Models;

public class IsOnlineResult
{
    public int Id { get; set; }
    public bool IsOnline { get; set; }
    public DateTime LastTime { get; set; }
}