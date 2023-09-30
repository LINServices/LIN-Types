using System.Text.Json.Serialization;

namespace LIN.Types.Developer.Models;


public class PDFResponse
{

    [JsonPropertyName("file")]
    public byte[] File { get; set; } = Array.Empty<byte>();


    [JsonPropertyName("sizeMB")]
    public decimal Peso { get; set; } = 0m;

}