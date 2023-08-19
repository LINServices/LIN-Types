using System.Security.Cryptography;

namespace LIN.Types.Tools;

public class Hash
{


    /// <summary>
    /// Genera el Hash de un perfil
    /// </summary>
    /// <param name="profile">Perfil</param>
    public static string GenerateHash(IProfile profile)
    {
        string final = $"{profile.AccountID}|{profile.ID}";
        var bytes = SHA512.HashData(Encoding.UTF8.GetBytes(final));
        return Convert.ToBase64String(bytes);
    }



    /// <summary>
    /// Valida el hash de un perfil
    /// </summary>
    /// <param name="profile">Perfil</param>
    public static bool ValidateHash(IProfile profile)
    {
        var now = GenerateHash(profile);
        return now == profile.Hash;
    }


}