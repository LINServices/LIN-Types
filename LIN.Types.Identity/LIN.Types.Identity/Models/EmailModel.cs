namespace LIN.Types.Identity.Models;


public class EmailModel
{
    public int ID { get; set; }
    public string Email { get; set; } = string.Empty;
    public EmailStatus Status { get; set; }
    public bool IsDefault { get; set; } = false;
    public int UserID { get; set; }
}