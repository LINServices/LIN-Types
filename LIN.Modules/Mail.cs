using System.Text.RegularExpressions;

namespace LIN.Modules;


public class Mail
{
    public static bool Validar(string email)
    {
        // Expresión regular para validar el formato del correo electrónico
        var pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        // Validar el correo electrónico utilizando la expresión regular
        var isValid = Regex.IsMatch(email, pattern);

        return isValid;
    }
}