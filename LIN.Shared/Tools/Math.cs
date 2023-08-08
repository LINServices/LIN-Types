namespace LIN.Shared.Tools;


public class Pricing
{


    public static decimal ToNegative(decimal value)
    {


        if (value > 0)
            return value * -1;

        return value;

    }


    /// <summary>
    /// Calcula el precio total al aplicar un descuento
    /// </summary>
    /// <param name="originalPrice">Precio original</param>
    /// <param name="discountPercent">Porcentaje de descuento</param>
    public static decimal Discount(decimal originalPrice, int discountPercent)
    {

        // Limita el rango
        if (discountPercent < 0)
            discountPercent = 0;

        else if (discountPercent > 99)
            discountPercent = 99;


        // Calcula el monto del descuento
        decimal montoDescuento = (originalPrice * (discountPercent / 100.0m));

        // Precio con descuento
        decimal precioConDescuento = originalPrice - montoDescuento;

        if (precioConDescuento < 1)
            precioConDescuento = 1;

        return precioConDescuento;
    }



}