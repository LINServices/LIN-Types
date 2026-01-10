namespace LIN.Types.Responses;

public class ReadOneStringResponse : ResponseBase
{

    /// <summary>
    /// Modelo
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public ReadOneStringResponse()
    {
        Response = Responses.Undefined;
        Model = string.Empty;
    }

    public ReadOneStringResponse(string model)
    {
        Response = Responses.Undefined;
        Model = model;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    public ReadOneStringResponse(Responses response = Responses.Undefined)
    {
        Response = response;
        Model = string.Empty;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [JsonConstructor]
    public ReadOneStringResponse(Responses response, string model)
    {
        Response = response;
        Model = model;
    }

}