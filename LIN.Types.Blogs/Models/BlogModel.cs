﻿namespace LIN.Types.Blogs.Models;


public class BlogModel
{
    public int Id { get; set; }
    public List<PublicationModel> Publications { get; set; } 
    public Profile Profile { get; set; }
    public int ProfileId { get; set; }
}