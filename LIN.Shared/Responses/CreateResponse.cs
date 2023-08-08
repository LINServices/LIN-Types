
namespace LIN.Shared.Responses
{

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
        /// Nueva respuesta 
        /// </summary>
        public CreateResponse()
        {
            this.Response = Responses.Undefined;
            this.LastID = -1;
        }


        /// <summary>
        /// Nueva respuesta 
        /// </summary>
        /// <param name="response">Respuesta</param>
        /// <param name="lastID">ID</param>
        public CreateResponse(Responses response = Responses.Undefined, int lastID = -1, string message = "")
        {
            this.Response = response;
            this.LastID = lastID;
            this.Message = message;
        }



    }


}
