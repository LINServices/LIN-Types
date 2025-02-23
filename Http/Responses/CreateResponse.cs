﻿namespace Http.ResponsesList;

public class HttpCreateResponse : HttpResponseBase
{

    /// <summary>
    /// Nueva respuesta Create.
    /// </summary>
    public HttpCreateResponse()
    {
        var obj = new CreateResponse()
        {
            Response = Responses.Undefined,
            LastId = -1
        };
        Response = obj.Response;
        Build(obj);
    }


    /// <summary>
    /// Nueva respuesta 
    /// </summary>
    /// <param name="response">Respuesta</param>
    /// <param name="lastID">ID</param>
    public HttpCreateResponse(Responses response = Responses.Undefined, int lastID = -1, string message = "")
    {
        var obj = new CreateResponse()
        {
            Response = response,
            LastId = lastID,
            Message = message
        };
        Response = obj.Response;
        Build(obj);
    }


    /// <summary>
    /// Nueva respuesta.
    /// </summary>
    /// <param name="res">respuesta base.</param>
    public static implicit operator HttpCreateResponse(CreateResponse res)
    {
        return new()
        {
            Object = res,
            Response = res.Response
        };
    }

}