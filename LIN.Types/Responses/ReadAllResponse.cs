namespace LIN.Types.Responses;


public class ReadAllResponse<M> : ResponseBase
{

    /// <summary>
    /// Lista de modelos
    /// </summary>
    public List<M> Models { get; set; }


    /// <summary>
    /// Constructor
    /// </summary>
    public ReadAllResponse()
    {
        Response = Responses.Undefined;
        Models = [];
    }


    /// <summary>
    /// Constructor
    /// </summary>
    public ReadAllResponse(Responses response = Responses.Undefined)
    {
        Response = response;
        Models = [];
    }


    /// <summary>
    /// Constructor
    /// </summary>
    public ReadAllResponse(Responses response, List<M> models)
    {
        Response = response;
        Models = models ?? [];
    }

}