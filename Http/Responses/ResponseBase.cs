using System.Text.Json;

namespace Http.ResponsesList;


public class HttpResponseBase : IActionResult
{

    /// <summary>
    /// Respuesta de ka operación.
    /// </summary>
    public Responses Response
    {
        get => Object?.Response ?? Responses.Undefined; 
        set
        {
            if (Object == null)
                return;
            Object.Response = value;
        }
    }


    /// <summary>
    /// Objeto a JSON.
    /// </summary>
    private protected ResponseBase Object = new();







    public string? Message { get; set; } = null;


    public HttpResponseBase()
    {
    }


    /// <summary>
    /// Constructor
    /// </summary>
    public HttpResponseBase(Responses response = Responses.Undefined)
    {
        Response = response;
        Build(new(response));
    }



    protected void Build(ResponseBase obj)
    {
        Object = obj;
    }



    public async Task ExecuteResultAsync(ActionContext context)
    {
        Object!.Message = (Object.Message == null || Object.Message.Trim() == string.Empty ? Message : Object.Message) ?? "";
        context.HttpContext.Response.StatusCode = ResponseEncode(Response);
        context.HttpContext.Response.ContentType = "application/json";
        var json = System.Text.Json.JsonSerializer.Serialize(Object as object);

        await context.HttpContext.Response.WriteAsync(json);
    }




    public static implicit operator HttpResponseBase(ResponseBase res)
    {
        return new()
        {
            Object = res,
            Response = res.Response
        };
    }




    public static int ResponseEncode(Responses response)
    {

        return response switch
        {
            Responses.Success => 200,
            Responses.InvalidApiKey => 401,
            Responses.Unauthorized => 401,
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
            Responses.LoginBlockedByOrg => 403,
            Responses.UnauthorizedByOrg => 403,
            Responses.InsufficientStorage => 507,
            Responses.UnauthorizedByApp => 403,
            Responses.NotFoundDirectory => 404,
            Responses.PoliciesNotComplied => 400,
            Responses.IsLoading => 102,
            _ => 500
        };
    }

}