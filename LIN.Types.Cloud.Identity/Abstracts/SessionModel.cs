﻿namespace LIN.Types.Cloud.Identity.Abstracts;

public class SessionModel<T> where T : new()
{
    public AccountModel Account { get; set; } = null!;
    public T Profile { get; set; } = new();
}