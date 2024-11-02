namespace LIN.Types.Mail.Models;

public class EmailMessageModel
{
    public int UId { get; set; }
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public string Resume { get; set; }
    public string From { get; set; }
}