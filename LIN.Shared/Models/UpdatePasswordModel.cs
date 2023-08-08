namespace LIN.Shared.Models;


public class UpdatePasswordModel
{

    public int Account { get; set; }
    public string OldPassword { get; set; } = string.Empty;
    public string NewPassword { get; set; } = string.Empty;


}
