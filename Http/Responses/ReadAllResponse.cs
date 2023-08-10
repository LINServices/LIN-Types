namespace Http.ResponsesList;

public class HttpReadAllResponse<M> : HttpResponseBase
{


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
            Models = new List<M>()
        };
        Response = obj.Response;
        Build(obj);
    }



    /// <summary>
    /// Constructor
    /// </summary>
    public HttpReadAllResponse(Responses response, List<M> models)
    {
        var obj = new ReadAllResponse<M>
        {
            Response = response,
            Models = models ?? new List<M>()
        };
        Response = obj.Response;
        Build(obj);
    }




    public static implicit operator HttpReadAllResponse<M>(ReadAllResponse<M> res)
    {
        return new()
        {
            Object = res,
            Response = res.Response,
        };
    }



}
