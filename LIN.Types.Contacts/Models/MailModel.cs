namespace LIN.Types.Contacts.Models;


public class MailModel
{
    public int Id { get; set; }
    public string Email { get; set; } = string.Empty;
    public ProfileModel Profile { get; set; } = null!;
}