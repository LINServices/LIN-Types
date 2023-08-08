using System.Text;

namespace LIN.Shared.Tools;


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

            // numero maximo de random
            int chLeng = caracteres.Length;

            // generacion de la llave
            for (int i = 0; i <= length; i++)
            {
                int randomNumber = random.Next(0, chLeng);
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
    /// Genera un codigo OTP
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

            // numero maximo de random
            int chLeng = caracteres.Length;

            // generacion de la llave
            for (int i = 0; i <= length; i++)
            {
                int randomNumber = random.Next(0, chLeng);
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
