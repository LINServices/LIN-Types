using System.Security.Cryptography;
using System.Text;

namespace LIN.Shared.Security;


public static class EncryptClass
{

    /// <summary>
    /// Encripta una clave
    /// </summary>
    public static string Encrypt(string clave)
    {
        var bytes = SHA512.HashData(Encoding.UTF8.GetBytes(clave));
        return Convert.ToBase64String(bytes);
    }

}
