﻿namespace LIN.Types.Contacts.Models;


public class PhoneModel
{

    public int Id { get; set; }
    public string Number { get; set; } = string.Empty;
    public ProfileModel Profile { get; set; } = null!;

}