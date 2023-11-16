namespace LIN.Types.Responses;


/// <summary>
/// Respuesta de 'Crear'
/// </summary>
public class CreateResponse : ResponseBase
{

    /// <summary>
    /// ID del elemento
    /// </summary>
    public int LastID { get; set; } = -1;



    /// <summary>
    /// ID del elemento
    /// </summary>
    public string LastUnique { get; set; } = string.Empty;




    /// <summary>
    /// Nueva respuesta 
    /// </summary>
    public CreateResponse()
    {
        Response = Responses.Undefined;
        LastID = -1;
    }


    /// <summary>
    /// Nueva respuesta 
    /// </summary>
    /// <param name="response">Respuesta</param>
    /// <param name="lastID">ID</param>
    public CreateResponse(Responses response = Responses.Undefined, int lastID = -1, string message = "")
    {
        Response = response;
        LastID = lastID;
        Message = message;
    }






}