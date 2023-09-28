namespace LIN.Types.Auth.Enumerations;


public enum PassKeyStatus
{

    /// <summary>
    /// Estado desconocido
    /// </summary>
    Undefined,

    /// <summary>
    /// Correcto
    /// </summary>
    Success,

    /// <summary>
    /// Fallo
    /// </summary>
    Failed,

    /// <summary>
    /// Rechazado
    /// </summary>
    Rejected,

    /// <summary>
    /// Expirado
    /// </summary>
    Expired,

    /// <summary>
    /// Bloqueado por la organización
    /// </summary>
    BlockedByOrg

}