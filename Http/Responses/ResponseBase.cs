global using LIN.Types.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Http.ResponsesList;


public class HttpResponseBase : IActionResult
{


    public Responses Response { get; set; }
    public ResponseBase? Object;


    public HttpResponseBase()
    {
    }


    /// <summary>
    /// Constructor
    /// </summary>
    public HttpResponseBase(Responses response = Responses.Undefined)
    {
        Response = response;
        Build(new ResponseBase(response));
    }



    protected void Build(ResponseBase obj)
    {
        Object = obj;
    }



    public async Task ExecuteResultAsync(ActionContext context)
    {
        context.HttpContext.Response.StatusCode = ResponseEncode(Response);
        context.HttpContext.Response.ContentType = "application/json";
        var json = JsonConvert.SerializeObject(Object);
        await context.HttpContext.Response.WriteAsync(json);
    }




    public static implicit operator HttpResponseBase(ResponseBase res)
    {
        return new()
        {
            Object = res,
            Response = res.Response,
        };
    }




    public static int ResponseEncode(Responses response)
    {

        return response switch
        {
            Responses.Success => 200,
            Responses.InvalidApiKey => 401,
            Responses.PasswordShort => 400,
            Responses.NotRows => 404,
            Responses.NotExistProfile => 404,
            Responses.NotExistAccount => 404,
            Responses.Undefined => 500,
            Responses.NotConnection => 500,
            Responses.ExistAccount => 409,
            Responses.LockAccount => 423,
            Responses.DisableAccount => 423,
            Responses.InvalidPassword => 401,
            Responses.InvalidUser => 400,
            Responses.InvalidParam => 400,
            Responses.FirewallBlocked => 403,
            Responses.UnavailableService => 503,
            Responses.WithoutCredits => 202,
            _ => 500,
        };
    }

}