using System.Collections.Generic;

namespace LIN.Types.Exp.Search.Models;


public class Movie
{

    public string Name { get; set; }= string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Year { get; set; } = string.Empty;
    public string Released { get; set; } = string.Empty;
    public string Poster { get; set; } = string.Empty;
    public string Rating { get; set; } = string.Empty;
    public List<string> Actors { get; set; } = [];

}