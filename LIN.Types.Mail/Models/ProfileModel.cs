namespace LIN.Types.Mail.Models;

public class ProfileModel
{
    public string Email { get; set; }
    public long MaxSize { get; set; }
    public float Size { get; set; }
    public bool IsActive {  get; set; }
}