﻿namespace LIN.Types.Cloud.Identity.Models.Identities;

public class AccountModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Profile { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public Visibility Visibility { get; set; }
    public AccountTypes AccountType { get; set; }
    public IdentityModel Identity { get; set; } = null!;
    public int IdentityId { get; set; }
}