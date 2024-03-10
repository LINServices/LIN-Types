namespace LIN.Types.Exp.Search.Models;


public class SearchResult(string title, string link, string snippet)
{
    public string Title { get; set; } = title;
    public string Link { get; set; } = link;
    public string Snippet { get; set; } = snippet;


    public SearchResult() : this(string.Empty, string.Empty, string.Empty)
    { 
    }

}