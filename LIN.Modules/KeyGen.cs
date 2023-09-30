using System.Text;

namespace LIN.Modules;


public class KeyGen
{


    /// <summary>
    /// Genera una llave
    /// </summary>
    /// <param name="length">Tamaño primario de la llave</param>
    public static string Generate(int length, string prefix = "key.")
    {

        try
        {
            // Lista de caracteres
            const string caracteres = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

            // Estancia de random
            var random = new Random();

            // Guarda la key
            var key = new StringBuilder(length);

            // numero máximo de random
            var chLeng = caracteres.Length;

            // generación de la llave
            for (var i = 0; i <= length; i++)
            {
                var randomNumber = random.Next(0, chLeng);
                key.Append(caracteres[randomNumber]);
            }
            // Retorno de la key
            return prefix + key.ToString();
        }
        catch
        {
            return Generate(length, prefix);
        }


    }



    /// <summary>
    /// Genera un código OTP
    /// </summary>
    /// <param name="length">Tamaño</param>
    public static string GenerateOTP(int length)
    {

        try
        {
            // Lista de caracteres
            const string caracteres = "0123456789";

            // Estancia de random
            var random = new Random();

            // Guarda la key
            var key = new StringBuilder(length);

            // numero máximo de random
            var chLeng = caracteres.Length;

            // generación de la llave
            for (var i = 0; i <= length; i++)
            {
                var randomNumber = random.Next(0, chLeng);
                key.Append(caracteres[randomNumber]);
            }
            // Retorno de la key
            return key.ToString();
        }
        catch
        {
            return GenerateOTP(length);
        }


    }


}