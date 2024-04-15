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
    public string Message { get; set; } = "";


    /// <summary>
    /// Autenticación
    /// </summary>
    public string Token { get; set; } = "";


    public string StreamKey { get; set; } = "";


    public object AlternativeObject { get; set; }


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