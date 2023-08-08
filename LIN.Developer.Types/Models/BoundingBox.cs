namespace LIN.Developer.Types.Models;


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

        double margin = distanceKm / earthRadiusKm * degreesPerRadian;

        return margin;
    }

    public static BoundingBox CreateBoundingBox(double longitude, double latitude, double km)
    {

        var margin = CalculateMargin(km);

        double minX = longitude - margin;
        double minY = latitude - margin;
        double maxX = longitude + margin;
        double maxY = latitude + margin;

        return new BoundingBox
        {
            MinX = minX,
            MinY = minY,
            MaxX = maxX,
            MaxY = maxY
        };

    }
}
