namespace LIN.Types.Mail.Models;

public class EmailMessageModel
{
    public long UId { get; set; }
    public string To { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
    public string Resume { get; set; }
    public string From { get; set; }
    public bool IsSendByMe { get; set; }
    public bool IsRecent { get; set; }
    public bool IsImportant { get; set; }
    public bool IsSeen { get; set; }
}