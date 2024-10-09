namespace LIN.Types;

/// <summary>
/// Recomendaciones de lo que debe de tener un Perfil en LIN
/// </summary>
public interface IProfile
{

    /// <summary>
    /// ID del perfil
    /// </summary>
    public int Id { get; set; }


    /// <summary>
    /// Fecha de creación del perfil
    /// </summary>
    public DateTime Creation { get; set; }


    /// <summary>
    /// ID de la cuenta en LIN Auth
    /// </summary>
    public int AccountId { get; set; }

}