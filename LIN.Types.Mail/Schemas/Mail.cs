using System.Collections.Generic;

namespace LIN.Types.Mail.Schemas;

public class EmailSummary
{
    public string Resume { get; set; }
    public List<OtpCode> Otps { get; set; }
}

public class OtpCode
{
    public string Remitente { get; set; }
    public string Codigo { get; set; }
}