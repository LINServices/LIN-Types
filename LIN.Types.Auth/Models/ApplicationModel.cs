namespace LIN.Types.Auth.Models;


public class ApplicationModel
{

    public int ID { get; set; } = 0;
    public string Name { get; set; } = string.Empty;
    public string Key { get; set; } = string.Empty;
    public int AccountID { get; set; }

}