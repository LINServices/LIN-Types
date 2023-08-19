namespace LIN.Types.Auth.Abstracts;


/// <summary>
/// Recomendaciones de lo que debe de tener un Perfil en LIN
/// </summary>
public interface IProfile
{

    /// <summary>
    /// ID del perfil
    /// </summary>
    public int ID { get; set; }


    /// <summary>
    /// ID de la cuenta en LIN Auth
    /// </summary>
    public int AccountID { get; set; }


    /// <summary>
    /// Hash de verificación de seguridad
    /// </summary>
    public string Hash { get; set; }

}