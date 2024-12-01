namespace LIN.Types.Cloud.Models;

public class PublicFileModel
{
    public string Key { get; set; }
    public string Path { get; set; }
    public DateTime? Expires { get; set; }
    public int Bucket {  get; set; }
}