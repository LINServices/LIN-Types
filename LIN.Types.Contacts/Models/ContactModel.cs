﻿using LIN.Types.Contacts.Enumerations;

namespace LIN.Types.Contacts.Models;

public class ContactModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Picture { get; set; } = string.Empty;
    public List<MailModel> Mails { get; set; } = [];
    public List<PhoneModel> Phones { get; set; } = [];
    public DateTime Birthday { get; set; }
    public ContactTypes Type { get; set; }
    public ProfileModel Im { get; set; } = null!;

}