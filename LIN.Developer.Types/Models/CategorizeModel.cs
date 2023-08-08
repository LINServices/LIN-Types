namespace LIN.Developer.Types.Models;


public class CategorizeModel
{

    public LIN.Shared.Enumerations.Sentiment Sentiment { get; set; } = Shared.Enumerations.Sentiment.Undefined;
    public LIN.Shared.Enumerations.LangEnum Languaje { get; set; } = Shared.Enumerations.LangEnum.Undefined;


}
