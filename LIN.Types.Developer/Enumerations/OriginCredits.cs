namespace LIN.Types.Developer.Enumerations;

public enum TransactionTypes
{

    /// <summary>
    /// Desconocido
    /// </summary>
    None,

    /// <summary>
    /// Regalo
    /// </summary>
    Gift,

    /// <summary>
    /// Bono de regalo
    /// </summary>
    Bonus,

    /// <summary>
    /// Recarga (Tarjeta)
    /// </summary>
    Recharge,

    /// <summary>
    /// Reembolso
    /// </summary>
    Refund,

    /// <summary>
    /// Usado en un servicio
    /// </summary>
    UsedService,

    /// <summary>
    /// Quitados de la cuenta por alguna razor
    /// </summary>
    Booted
}