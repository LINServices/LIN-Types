﻿using LIN.Types.Identity.Models;

namespace LIN.Types.Identity.Abstracts;


public class AuthModel<T> where T : new()
{

    public AccountModel Account { get; set; } = new();

    public T Profile { get; set; } = new();

    public Dictionary<string, string> TokenCollection { get; set; } = new();

}