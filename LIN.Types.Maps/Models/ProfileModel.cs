namespace LIN.Types.Maps.Models;


public class ProfileModel
{

    public int ID { get; set; }

    public int AccountID { get; set; }

    public List<PlacePoint> PlacesPoint { get; set; } = [];

}