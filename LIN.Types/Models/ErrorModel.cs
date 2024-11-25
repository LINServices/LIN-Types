using LIN.Types.Enumerations;

namespace LIN.Types.Models;

public class ErrorModel
{
    public string Code { get; set; }
    public string Tittle { get; set; }
    public string Description { get; set; }
    public ErrorTypes Type { get; set; }
}