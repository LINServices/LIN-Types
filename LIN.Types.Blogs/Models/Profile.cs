﻿namespace LIN.Types.Blogs.Models;

public class Profile
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; }
    public int AccountId { get; set; }
}