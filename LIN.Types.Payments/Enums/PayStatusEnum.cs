namespace LIN.Types.Payments.Enums;

public enum PayStatusEnum
{

    /// <summary>
    /// Sin definir.
    /// </summary>
    NotDefined,

    /// <summary>
    /// El pago ha sido aprobado y acreditado exitosamente.
    /// </summary>
    Approved,

    /// <summary>
    /// El pago está en proceso de revisión y aún no ha sido acreditado.
    /// </summary>
    Pending,

    /// <summary>
    /// El pago fue rechazado y no se acreditó.
    /// </summary>
    Rejected,

    /// <summary>
    /// El pago fue devuelto al comprador.
    /// </summary>
    Refunded
}