using Microsoft.AspNetCore.Mvc.Filters;
using System.Text;
using System.Text.Json;

namespace Http.Services;


public class StreamResponse
{
    public byte[] Data { get; set; }
}


public class StreamResponsesAttribute : ActionFilterAttribute
{


    public static Dictionary<string, List<StreamResponse>> StreamResponses { get; set; } = [];




    public static void Set(string key, object objecto)
    {


        var x = JsonSerializer.SerializeToUtf8Bytes(objecto);


        var xx = new List<StreamResponse>();
        StreamResponses.Add(key, xx);


        // Dividir el arreglo en segmentos de 20000 bytes
        byte[][] segments = SplitByteArray(x, 20000);


        foreach (var e in segments)
        {
            xx.Add(new()
            {
                Data = e
            });
        }
    }




    /// <summary>
    /// Filtro del token.
    /// </summary>
    /// <param name="context">Contexto HTTP.</param>
    /// <param name="next">Siguiente.</param>
    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {

        // Contexto HTTP.
        var httpContext = context.HttpContext;

        // Obtiene el valor.
        bool can = httpContext.Request.Headers.TryGetValue("stream-content", out Microsoft.Extensions.Primitives.StringValues value);

        List<StreamResponse> streamResponses = [];

        // No existe.
        if (!can)
        {

            await base.OnActionExecutionAsync(context, next);

            httpContext.Response.StatusCode = 200;
           
            return;


        }


        // Buscar el contenido.
        string idContent = value.ToString();


        var str = StreamResponses.TryGetValue(idContent, out var lista);

        if (!str || lista?.Count <= 0)
        {
            httpContext.Response.StatusCode = 200;
            await httpContext.Response.WriteAsJsonAsync(new ResponseBase()
            {
                Response = Responses.ClosedStream
            });
            return;
        }


        var valor = lista!.First();

        lista!.RemoveAt(0);

        httpContext.Response.StatusCode = 200;
        await httpContext.Response.WriteAsJsonAsync(new ReadAllResponse<byte>()
        {
            StreamKey = idContent,
            Models = valor.Data.ToList(),
            Response = Responses.Success
        });


    }


    static string StreamToString(Stream stream)
    {
        // Crear un StreamReader para leer el flujo
        using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
        {
            // Leer todo el contenido del flujo y devolverlo como una cadena
            return reader.ReadToEnd();
        }
    }


    static byte[][] SplitByteArray(byte[] array, int segmentSize)
    {
        int numSegments = (int)Math.Ceiling((double)array.Length / segmentSize);
        byte[][] segments = new byte[numSegments][];

        for (int i = 0; i < numSegments; i++)
        {
            int length = Math.Min(segmentSize, array.Length - i * segmentSize);
            byte[] segment = new byte[length];
            Array.Copy(array, i * segmentSize, segment, 0, length);
            segments[i] = segment;
        }

        return segments;
    }


    static byte[] StreamToByteArray(Stream stream)
    {
        // Crear un MemoryStream para almacenar los datos leídos del flujo
        using (MemoryStream memoryStream = new MemoryStream())
        {
            // Leer el flujo y escribir los datos en el MemoryStream
            stream.CopyTo(memoryStream);

            // Devolver el arreglo de bytes obtenido del MemoryStream
            return memoryStream.ToArray();
        }
    }

}
