namespace LIN.Types.Responses;


public class ResponseBase
{

    /// <summary>
    /// Respuesta
    /// </summary>
    public Responses Response { get; set; } = Responses.Undefined;


    /// <summary>
    /// Mensaje del elemeto
    /// </summary>
    public string Message { get; set; } = "";


    /// <summary>
    /// Autenticacion
    /// </summary>
    public string Token { get; set; } = "";



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
