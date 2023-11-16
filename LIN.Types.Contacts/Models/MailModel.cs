namespace LIN.Types.Contacts.Models;


public class MailModel
{
    public int Id { get; set; }
    public string Email { get; set; }
    public ProfileModel Profile { get; set; }
}