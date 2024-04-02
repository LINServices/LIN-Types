using System.Collections.Generic;

namespace LIN.Types.Exp.Search.Models;


public class Movie
{

    public string Name { get; set; }
    public string Description { get; set; }
    public string Year { get; set; }
    public string Released { get; set; }
    public string Poster { get; set; }
    public string Rating { get; set; }
    public List<string> Actors { get; set; }

}