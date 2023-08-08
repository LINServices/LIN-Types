﻿using System.Text.Json.Serialization;

namespace LIN.Shared.Responses
{
    public class ReadOneResponse<M> : ResponseBase where M : new()
    {

        /// <summary>
        /// Modelo
        /// </summary>
        public M Model { get; set; }




        /// <summary>
        /// Constructor
        /// </summary>
        public ReadOneResponse()
        {
            Response = Responses.Undefined;
            Model = new();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public ReadOneResponse(Responses response = Responses.Undefined)
        {
            Response = response;
            Model = new();
        }


        /// <summary>
        /// Constructor
        /// </summary>
        [JsonConstructor]
        public ReadOneResponse(Responses response, M model)
        {
            Response = response;
            Model = model;
        }


    }
}
