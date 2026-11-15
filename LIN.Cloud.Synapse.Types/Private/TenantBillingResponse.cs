namespace LIN.Cloud.Synapse.Types.Private;

/// <summary>Estado de facturación de un tenant.</summary>
public class TenantBillingResponse
{
    /// <summary>Importe ya reportado a facturación (histórico).</summary>
    public decimal ReportedAmount { get; set; }

    /// <summary>Importe pendiente de reportar (histórico).</summary>
    public decimal PendingAmount { get; set; }

    /// <summary>Instante de la consulta (UTC).</summary>
    public DateTime AsOfUtc { get; set; }
}
