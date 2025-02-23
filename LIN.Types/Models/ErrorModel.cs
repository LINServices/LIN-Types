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

    /// <summary>
    /// Desde valor vacío.
    /// </summary>
    public static ErrorModel? FromEmpty(string value, string fieldName)
    {
        if (string.IsNullOrWhiteSpace(value))
            return null;

        return new ErrorModel()
        {
            Code = "400",
            Type = ErrorTypes.None,
            Tittle = $"Campo '{fieldName}' invalido.",
            Description = $"El campo '{fieldName}' no puede ser nulo o vacío."
        };
    }

    /// <summary>
    /// Desde valor vacío.
    /// </summary>
    public static ErrorModel? FromBadRequest(object @object)
    {
        if (@object is not null)
            return null;

        return new ErrorModel()
        {
            Code = "400",
            Type = ErrorTypes.None,
            Tittle = $"Objeto de entrada invalido.",
            Description = $"Revisa el formato del objeto enviado."
        };
    }
}