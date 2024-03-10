using LIN.Types.Exp.Search.Enums;

namespace LIN.Types.Exp.Search.Models;



public class Weather
{

    public string CityName { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public Condition Condition { get; set; }
    public Wind Wind { get; set; }
    public Temperature Temperature { get; set; }


}
