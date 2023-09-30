using System.Text.RegularExpressions;
using System.Net;
namespace LIN.Modules;


public class IP
{



    public static bool IsIpInRange(string ipAddress, string startRange, string endRange)
    {
        var startIPAddress = IPAddress.Parse(startRange);
        var endIPAddress = IPAddress.Parse(endRange);
        var targetIPAddress = IPAddress.Parse(ipAddress);

        // Convertir las direcciones IP a enteros para comparar
        var startIPInt = BitConverter.ToUInt32(startIPAddress.GetAddressBytes(), 0);
        var endIPInt = BitConverter.ToUInt32(endIPAddress.GetAddressBytes(), 0);
        var targetIPInt = BitConverter.ToUInt32(targetIPAddress.GetAddressBytes(), 0);

        return targetIPInt >= startIPInt && targetIPInt <= endIPInt;
    }



    /// <summary>
    /// Valida una direccion IPv4
    /// </summary>
    /// <param name="direccion">Direccion a validar</param>
    public static bool ValidateIPv4(string direccion)
    {
        var patron = @"^(\d{1,3}\.){3}\d{1,3}$"; // Expresión regular para IPv4
        if (Regex.IsMatch(direccion, patron))
        {
            string[] octetos = direccion.Split('.');
            foreach (var octeto in octetos)
                if (!int.TryParse(octeto, out var valor) || valor < 0 || valor > 255)
                    return false;
            return true;
        }

        return false;
    }


}