namespace LIN.Types.Models;


public class EmmaRequest
{

    public bool IncludeEmma { get; set; } = true;
    public bool IncludeAppContext { get; set; } = true;
    public bool IncludeEmmaMethods { get; set; } = true;
    public bool IncludeGeneralMethods { get; set; } = true;
    public bool IncludeAppsMethods { get; set; } = true;
    public bool IncludeDefaultTopics { get; set; } = true;


    public string AppContext {  get; set; }
    public string EmmaMethods {  get; set; }
    public string AppsMethods {  get; set; }
    public string AdditionalTopics {  get; set; }

    public string Asks {  get; set; }


}