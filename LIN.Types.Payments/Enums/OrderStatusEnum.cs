namespace LIN.Types.Payments.Enums;

public enum OrderStatusEnum
{
    Generated, // Orden generada.
    Pending, // La orden está pendiente de pago.
    Paid, // Todos los pagos de la orden fueron aprobados.
    PartiallyPaid, // Algunos pagos de la orden fueron aprobados, pero aún hay saldo pendiente.
    Expired, // La orden ha expirado antes de completarse.
    Cancelled, // Cancelado.
    Reverted, // Revertida.
    PaymentRequired, // Requerido de pago.
    Closed // Cerrada.
}
