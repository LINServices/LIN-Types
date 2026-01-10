using LIN.Types.Models;

namespace LIN.Types.Responses;

public class ResponseBase
{
    /// <summary>
    /// Lista de errores.
    /// </summary>
    public List<ErrorModel> Errors { get; set; } = [];

    /// <summary>
    /// Respuesta
    /// </summary>
    public Responses Response { get; set; } = Responses.Undefined;

    /// <summary>
    /// Mensaje del elemento
    /// </summary>
    public string Message { get; set; } = string.Empty;

    /// <summary>
    /// Autenticación
    /// </summary>
    public string Token { get; set; } = string.Empty;

    /// <summary>
    /// Objeto alternativo
    /// </summary>
    public List<object> Alternatives { get; set; } = [];

    /// <summary>
    /// Constructor
    /// </summary>
    public ResponseBase()
    {
        Response = Responses.Undefined;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    public ResponseBase(Responses response = Responses.Undefined)
    {
        Response = response;
    }
}