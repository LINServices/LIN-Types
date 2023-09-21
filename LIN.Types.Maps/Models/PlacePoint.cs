namespace LIN.Types.Maps.Models;


internal class PlacePoint
{
    public int ID { get; set; }
    public double Longitude { get; set; }
    public double Latitude { get; set; }
    public DateTime Time { get; set; }
    public ProfileModel Profile { get; set; }

}
