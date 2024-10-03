namespace LIN.Types.Developer.Models;


public class CategorizeModel
{

    public Sentiments Sentiment { get; set; } = Sentiments.Undefined;
    public Languages Language { get; set; } = Languages.Undefined;

}