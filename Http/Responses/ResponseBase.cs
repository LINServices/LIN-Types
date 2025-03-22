using LIN.Types.Models;

namespace Http.ResponsesList;

public class HttpResponseBase : IActionResult
{

    /// <summary>
    /// Nueva respuesta.
    /// </summary>
    public HttpResponseBase() : this(Responses.Undefined)
    {
    }


    /// <summary>
    /// Errores.
    /// </summary>
    public List<ErrorModel> Errors
    {
        get => Object?.Errors ?? [];
        set
        {
            if (Object is null)
                return;
            Object.Errors = value;
        }
    }


    /// <summary>
    /// Respuesta de ka operación.
    /// </summary>
    public Responses Response
    {
        get => Object?.Response ?? Responses.Undefined;
        set
        {
            if (Object is null)
                return;
            Object.Response = value;
        }
    }


    /// <summary>
    /// Objeto a JSON.
    /// </summary>
    private protected ResponseBase Object = new();


    /// <summary>
    /// Mensaje.
    /// </summary>
    public string? Message { get; set; } = null;


    /// <summary>
    /// Constructor
    /// </summary>
    public HttpResponseBase(Responses response)
    {
        Response = response;
        Build(new(response));
    }


    /// <summary>
    /// Contruir respuesta.
    /// </summary>
    protected void Build(ResponseBase obj)
    {
        Object = obj;
    }


    /// <summary>
    /// Ejecutar resultado.
    /// </summary>
    /// <param name="context">Contexto.</param>
    public async Task ExecuteResultAsync(ActionContext context)
    {

        for (int i = 0; i < Object.Alternatives.Count; i++)
        {
            Object.Alternatives[i] = Newtonsoft.Json.JsonConvert.SerializeObject(Object.Alternatives[i]);
        }

        Object!.Message = (Object.Message is null || Object.Message.Trim() == string.Empty ? Message : Object.Message) ?? "";
        context.HttpContext.Response.StatusCode = ResponseEncode(Response);
        context.HttpContext.Response.ContentType = "application/json";

        var json = Newtonsoft.Json.JsonConvert.SerializeObject(Object);
        await context.HttpContext.Response.WriteAsync(json);
    }


    /// <summary>
    /// Operador de conversion.
    /// </summary>
    /// <param name="res"></param>
    public static implicit operator HttpResponseBase(ResponseBase res)
    {
        return new()
        {
            Object = res,
            Response = res.Response
        };
    }


    /// <summary>
    /// Respuestas a códigos de estado.
    /// </summary>
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
            Responses.NotConnection => 503,
            Responses.ExistAccount => 409,
            Responses.LockAccount => 423,
            Responses.DisableAccount => 403,
            Responses.InvalidPassword => 401,
            Responses.InvalidUser => 400,
            Responses.InvalidParam => 400,
            Responses.FirewallBlocked => 403,
            Responses.UnavailableService => 503,
            Responses.WithoutCredits => 402,
            Responses.LoginBlockedByOrg => 403,
            Responses.UnauthorizedByOrg => 403,
            Responses.InsufficientStorage => 507,
            Responses.UnauthorizedByApp => 403,
            Responses.NotFoundDirectory => 404,
            Responses.PoliciesNotComplied => 403,
            Responses.ResourceExist => 409,
            Responses.IsLoading => 102,
            Responses.RateLimitExceeded => 429,
            _ => 500
        };
    }

}