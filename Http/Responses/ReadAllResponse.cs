namespace Http.ResponsesList;

public class HttpReadAllResponse<M> : HttpResponseBase
{

    /// <summary>
    /// Nueva respuesta.
    /// </summary>
    public HttpReadAllResponse()
    {
        var obj = new ReadAllResponse<M>()
        {
            Response = Responses.Undefined
        };

        Response = obj.Response;
        Build(obj);
    }


    /// <summary>
    /// Constructor
    /// </summary>
    public HttpReadAllResponse(Responses response = Responses.Undefined)
    {
        var obj = new ReadAllResponse<M>
        {
            Response = response,
            Models = []
        };
        Response = obj.Response;
        Build(obj);
    }


    /// <summary>
    /// Constructor
    /// </summary>
    public HttpReadAllResponse(Responses response, IEnumerable<M> models)
    {
        var obj = new ReadAllResponse<M>
        {
            Response = response,
            Models = models.ToList() ?? []
        };
        Response = obj.Response;
        Build(obj);
    }


    /// <summary>
    /// Operador de conversion.
    /// </summary>
    public static implicit operator HttpReadAllResponse<M>(ReadAllResponse<M> res)
    {
        return new()
        {
            Object = res,
            Response = res.Response
        };
    }

}