namespace LIN.Types.Identity.Enumerations;


public enum Roles
{

    /// <summary>
    /// Rol no definido.
    /// </summary>
    Undefine,

    /// <summary>
    /// Invitado: Sin permisos.
    /// </summary>
    Guest,

    /// <summary>
    /// Invitado: Con permisos.
    /// </summary>
    RoyalGuest,

    /// <summary>
    /// Rol de usuario regular.
    /// </summary>
    Regular,

    /// <summary>
    /// Operador de cuentas de usuario.
    /// </summary>
    AccountsOperator,

    /// <summary>
    /// Rol de operador.
    /// </summary>
    Operator,

    /// <summary>
    /// Rol de administrador general.
    /// </summary>
    Manager,

    /// <summary>
    /// Rol de super administrador.
    /// </summary>
    SuperManager,

    /// <summary>
    /// Rol de sistema.
    /// </summary>
    System

}
