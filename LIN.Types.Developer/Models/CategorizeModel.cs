namespace LIN.Types.Developer.Models;


public class CategorizeModel
{

    public Shared.Enumerations.Sentiment Sentiment { get; set; } = Shared.Enumerations.Sentiment.Undefined;
    public Shared.Enumerations.LangEnum Languaje { get; set; } = Shared.Enumerations.LangEnum.Undefined;


}
