namespace LIN.Types;


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
    /// Fecha de creación del perfil
    /// </summary>
    public DateTime Creación { get; set; }


    /// <summary>
    /// ID de la cuenta en LIN Auth
    /// </summary>
    public int AccountID { get; set; }

}