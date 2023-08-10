namespace LIN.Types.Responses;


/// <summary>
/// Enumeración de respuestas
/// </summary>
public enum Responses
{

    /// <summary>
    /// Error indefinido
    /// </summary>
    Undefined,

    /// <summary>
    /// Correctamente
    /// </summary>
    Success,

    /// <summary>
    /// Sin conexión
    /// </summary>
    NotConnection,

    /// <summary>
    /// No existe una cuenta
    /// </summary>
    NotExistAccount,

    /// <summary>
    /// Ya existe una cuenta
    /// </summary>
    ExistAccount,

    /// <summary>
    /// Cuenta bloqueada
    /// </summary>
    LockAccount,

    /// <summary>
    /// Cuenta desactivada
    /// </summary>
    DisableAccount,

    /// <summary>
    /// Parámetro invalido
    /// </summary>
    InvalidParam,


    /// <summary>
    /// No hay columnas que mostrar
    /// </summary>
    NotRows,

    /// <summary>
    /// Contraseña corta
    /// </summary>
    PasswordShort,

    /// <summary>
    /// Usuario invalido
    /// </summary>
    InvalidUser,

   
    /// <summary>
    /// No existe el perfil
    /// </summary>
    NotExistProfile,

    /// <summary>
    /// No existe el perfil
    /// </summary>
    WithoutCredits,

    /// <summary>
    /// No tiene permisos
    /// </summary>
    Unauthorized,

    /// <summary>
    /// Api key invalida
    /// </summary>
    InvalidApiKey,

    /// <summary>
    /// Firewall Block
    /// </summary>
    FirewallBlocked,


    InvalidPassword,


    /// <summary>
    /// Servicio no disponible
    /// </summary>
    UnavailableService


}
