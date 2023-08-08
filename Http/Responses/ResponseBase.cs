using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LIN.Shared.Responses;


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
            Responses.UserVoid => 400,
            Responses.NameVoid => 400,
            Responses.PasswordVoid => 400,
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
            Responses.InvalidParamText => 400,
            Responses.InvalidParamNum => 400,
            Responses.InvalidUser => 400,
            Responses.InvalidParam => 400,
            Responses.DontHaveCredits => 402,
            Responses.DontHavePermissions => 401,
            Responses.FirewallBlocked => 403,
            Responses.UnavailableService => 503,
            _ => 500,
        };
    }

}