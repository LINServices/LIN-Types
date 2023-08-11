namespace LIN.Types.Auth.Models;


public class UniqueLink
{

    public int ID { get; set; }

    public string Key { get; set; } = string.Empty;

    public int AccountID { get; set; }

    public MagicLinkStatus Status { get; set; }

    public DateTime Vencimiento { get; set; }

}