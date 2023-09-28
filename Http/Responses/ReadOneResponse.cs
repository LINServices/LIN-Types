namespace Http.ResponsesList;


public class HttpReadOneResponse<M> : HttpResponseBase where M : new()
{

    public HttpReadOneResponse()
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
    public HttpReadOneResponse(Responses response = Responses.Undefined)
    {
        var obj = new ReadOneResponse<M>()
        {
            Response = response,
            Model = new()
        };
        Response = obj.Response;
        Build(obj);
    }


    /// <summary>
    /// Constructor
    /// </summary>
    public HttpReadOneResponse(Responses response, M model)
    {
        var obj = new ReadOneResponse<M>()
        {
            Response = response,
            Model = model
        };
        Response = obj.Response;
        Build(obj);
    }




    public static implicit operator HttpReadOneResponse<M>(ReadOneResponse<M> res)
    {
        return new()
        {
            Object = res,
            Response = res.Response,
        };
    }


}