namespace LIN.Types.Responses;

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

    /// <summary>
    /// Contraseña invalida.
    /// </summary>
    InvalidPassword,

    /// <summary>
    /// Servicio no disponible
    /// </summary>
    UnavailableService,

    /// <summary>
    /// Desautorizado por la organización.
    /// </summary>
    UnauthorizedByOrg,

    /// <summary>
    /// Login bloqueado por la organización.
    /// </summary>
    LoginBlockedByOrg,

    /// <summary>
    /// Espacio insuficiente
    /// </summary>
    InsufficientStorage,

    /// <summary>
    /// Aplicación no autorizada
    /// </summary>
    UnauthorizedByApp,

    /// <summary>
    /// Directorio no encontrado.
    /// </summary>
    NotFoundDirectory,

    /// <summary>
    /// No cumple con las políticas.
    /// </summary>
    PoliciesNotComplied,

    /// <summary>
    /// Cargando.
    /// </summary>
    IsLoading,

    /// <summary>
    /// Recurso ya existe.
    /// </summary>
    ResourceExist,

    [Obsolete]
    ClosedStream,

    /// <summary>
    /// Limite excedido.
    /// </summary>
    RateLimitExceeded,
}