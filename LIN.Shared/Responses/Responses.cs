namespace LIN.Shared.Responses
{

    /// <summary>
    /// Enumeracion de respuestas
    /// </summary>
    public enum Responses
    {

        /// <summary>
        /// Error indefinido
        /// </summary>
        Undefined,

        /// <summary>
        /// Accion realizada con exito
        /// </summary>
        Success,

        /// <summary>
        /// Sin conexion a la base de datos
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
        /// Contraseña invalida
        /// </summary>
        InvalidPassword,

        /// <summary>
        /// Parametro de texto invalido
        /// </summary>
        InvalidParamText,

        /// <summary>
        /// Parametro de numero invalido
        /// </summary>
        InvalidParamNum,

        /// <summary>
        /// No hay columnas que mostrar
        /// </summary>
        NotRows,

        /// <summary>
        /// UserDataModel vacio
        /// </summary>
        UserVoid,

        /// <summary>
        /// Contraseña vacia
        /// </summary>
        PasswordVoid,

        /// <summary>
        /// Contraseña corta
        /// </summary>
        PasswordShort,

        /// <summary>
        /// Nombre vacia
        /// </summary>
        NameVoid,

        /// <summary>
        /// Usuario invalido
        /// </summary>
        InvalidUser,

        /// <summary>
        /// Parametro invalido
        /// </summary>
        InvalidParam,

        /// <summary>
        /// No existe el perfil
        /// </summary>
        NotExistProfile,

        /// <summary>
        /// No existe el perfil
        /// </summary>
        DontHaveCredits,

        /// <summary>
        /// No tiene permisos
        /// </summary>
        DontHavePermissions,

        /// <summary>
        /// Api key invalida
        /// </summary>
        InvalidApiKey,

        /// <summary>
        /// Firewall Block
        /// </summary>
        FirewallBlocked,

        /// <summary>
        /// Servicio no disponible
        /// </summary>
        UnavailableService


    }

}
