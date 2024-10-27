namespace LIN.Types.Cloud.Identity.Enumerations;

public enum PolicyRequirementTypes
{
    /// <summary>
    /// Solo por horas especificas.
    /// </summary>
    Time,
    /// <summary>
    /// Tener doble factor de autenticación.
    /// </summary>
    TFA,
    /// <summary>
    /// Haber cambiado la contraseña hace un tiempo especifico.
    /// </summary>
    PasswordTime
}