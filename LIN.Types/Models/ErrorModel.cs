using LIN.Types.Enumerations;

namespace LIN.Types.Models;

public class ErrorModel(string code, string message, string description, ErrorTypes errorType)
{

    public ErrorModel(string message) : this(string.Empty, message, string.Empty, ErrorTypes.None)
    {
    }

    public ErrorModel(string code, string message) : this(code, message, string.Empty, ErrorTypes.None)
    {
    }

    public ErrorModel() : this(string.Empty, string.Empty, string.Empty, ErrorTypes.None)
    {
    }

    public string Code { get; set; } = code;
    public string Tittle { get; set; } = message;
    public string Description { get; set; } = description;
    public ErrorTypes Type { get; set; } = errorType;
}