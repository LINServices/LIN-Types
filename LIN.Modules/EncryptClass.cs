using System.Security.Cryptography;
using System.Text;

namespace LIN.Modules;


public static class EncryptClass
{

    /// <summary>
    /// Encripta una clave
    /// </summary>
    public static string Encrypt(string clave)
    {

        // Convert the input string to a byte array
        byte[] inputBytes = Encoding.UTF8.GetBytes(clave);

        // Create a SHA-512 hash object
        using SHA512 sha512 = SHA512.Create();

        // Compute the hash value from the input bytes
        byte[] hashBytes = sha512.ComputeHash(inputBytes);

        return Convert.ToBase64String(hashBytes);

    }

}