﻿namespace LIN.Types.Communication.Models;


public class ProfileModel
{
    public int ID { get; set; }
    public string Alias { get; set; } = string.Empty;
    public List<ProfileModel> Friends { get; set; } = new();

}
