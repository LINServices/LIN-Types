using LIN.Types.Contacts.Enumerations;

namespace LIN.Types.Contacts.Models;


public class ContactModel
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public byte[] Picture { get; set; } = [];
    public List<MailModel> Mails { get; set; } = [];
    public List<PhoneModel> Phones { get; set; } = [];
    public DateTime Birthday { get; set; }
    public ContactTypes Type { get; set; }
    public ProfileModel Im { get; set; } = null!;

}