namespace LIN.Types.Cloud.Models;


public class FileModel
{

    public string Name { get; set; } = string.Empty;

    public string Route { get; set; } = string.Empty;
    public string MimeType { get; set; } = string.Empty;

    public byte[] Data { get; set; } = [];

}
