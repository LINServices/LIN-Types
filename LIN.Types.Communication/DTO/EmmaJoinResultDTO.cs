namespace LIN.Types.Communication.DTO;

public class EmmaJoinResultDTO
{
    public string PeerId { get; set; } = string.Empty;
    public bool AlreadyPresent { get; set; }
}
