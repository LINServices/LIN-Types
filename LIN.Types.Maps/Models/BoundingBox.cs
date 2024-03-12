namespace LIN.Types.Maps.Models;


public class BoundingBox
{
    public double MinX { get; set; }
    public double MinY { get; set; }
    public double MaxX { get; set; }
    public double MaxY { get; set; }




    private static double CalculateMargin(double distanceKm)
    {
        const double earthRadiusKm = 6371; // Radio de la Tierra en kilómetros
        const double degreesPerRadian = 180.0 / Math.PI;

        var margin = distanceKm / earthRadiusKm * degreesPerRadian;

        return margin;
    }

    public static BoundingBox CreateBoundingBox(double longitude, double latitude, double km)
    {

        var margin = CalculateMargin(km);

        var minX = longitude - margin;
        var minY = latitude - margin;
        var maxX = longitude + margin;
        var maxY = latitude + margin;

        return new()
        {
            MinX = minX,
            MinY = minY,
            MaxX = maxX,
            MaxY = maxY
        };

    }
}