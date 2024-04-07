namespace LIN.Types.Notes.Transient;


public class CommandModel
{
    public string Command { get; set; } = string.Empty;
    public int Inventory { get; set; }
    public bool IsGeneral { get; set; }
}
