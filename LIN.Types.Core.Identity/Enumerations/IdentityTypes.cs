namespace LIN.Types.Core.Identity.Enumerations;

public enum IdentityTypes
{
    /// <summary>
    /// Cuenta de usuario.
    /// </summary>
    Account = 'A',

    /// <summary>
    /// Identidad de una organización.
    /// </summary>
    Organization = 'O',

    /// <summary>
    /// Identidad de un directorio.
    /// </summary>
    Group = 'G',

    /// <summary>
    /// Identidad de un servicio o aplicación.
    /// </summary>
    Service = 'S'
}