using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIN.Shared.Tools;

public class Utilities
{


    public static string IntToMonth(int value)
    {
        switch(value)
        {
            case 1:
                return "Enero";
            case 2:
                return "Febrero";
            case 3:
                return "Marzo";
            case 4:
                return "Abril";
            case 5:
                return "Mayo";
            case 6:
                return "Junio";
            case 7:
                return "Julio";
            case 8:
                return "Agosto";
            case 9:
                return "Septiembre";
            case 10:
                return "Octubre";
            case 11:
                return "Noviembre";
            case 12:
                return "Diciembre";
            default:
                return "Undefined";
        }
    }


    public static string CensorEmail(string email)
    {
        int atIndex = email.IndexOf("@");
        if (atIndex != -1)
        {
            string username = email.Substring(0, atIndex);
            string censoredUsername = CensorString(username);
            string domain = email.Substring(atIndex);

            return censoredUsername + domain;
        }

        return email;
    }

    private static string CensorString(string input)
    {
        int length = input.Length;
        string censored;

        if (length <= 4)
        {
            // If the string has 4 or fewer characters, we don't censor any characters
            censored = input;
        }
        else
        {
            // Keep the first four characters and censor the rest with asterisks
            censored = input.Substring(0, 4) + new string('*', length - 4);
        }

        return censored;
    }
}
