using System.Text.RegularExpressions;
using System.Net;
namespace LIN.Modules;


public class IP
{



    public static bool IsIpInRange(string ipAddress, string startRange, string endRange)
    {
        IPAddress startIPAddress = IPAddress.Parse(startRange);
        IPAddress endIPAddress = IPAddress.Parse(endRange);
        IPAddress targetIPAddress = IPAddress.Parse(ipAddress);

        // Convertir las direcciones IP a enteros para comparar
        uint startIPInt = BitConverter.ToUInt32(startIPAddress.GetAddressBytes(), 0);
        uint endIPInt = BitConverter.ToUInt32(endIPAddress.GetAddressBytes(), 0);
        uint targetIPInt = BitConverter.ToUInt32(targetIPAddress.GetAddressBytes(), 0);

        return (targetIPInt >= startIPInt && targetIPInt <= endIPInt);
    }



    /// <summary>
    /// Valida una direccion IPv4
    /// </summary>
    /// <param name="direccion">Direccion a validar</param>
    public static bool ValidateIPv4(string direccion)
    {
        string patron = @"^(\d{1,3}\.){3}\d{1,3}$"; // Expresión regular para IPv4
        if (Regex.IsMatch(direccion, patron))
        {
            string[] octetos = direccion.Split('.');
            foreach (string octeto in octetos)
                if (!int.TryParse(octeto, out int valor) || valor < 0 || valor > 255)
                    return false;
            return true;
        }

        return false;
    }


}
