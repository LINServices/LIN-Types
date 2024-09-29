namespace LIN.Types.Developer.Models;

public class MailingResult
{
    public int Id { get; set; }
    public int StatusCode { get; set; }
    public string EndMessage { get; set; } = string.Empty;
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
}