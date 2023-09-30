namespace LIN.Types.Developer.Models;


public class CategorizeModel
{

    public Sentiments Sentiment { get; set; } = Sentiments.Undefined;
    public Languajes Languaje { get; set; } = Languajes.Undefined;

}