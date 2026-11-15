namespace LIN.Cloud.Synapse.Types.Private;

/// <summary>Uso de un tenant en un rango de fechas.</summary>
public class TenantUsageResponse
{
    /// <summary>Inicio del rango (UTC, inclusivo, efectivo tras aplicar valores por defecto).</summary>
    public DateTime From { get; set; }

    /// <summary>Fin del rango (UTC, exclusivo).</summary>
    public DateTime To { get; set; }

    /// <summary>Uso por modelo, ordenado por importe descendente y luego por modelo ascendente.</summary>
    public List<TenantModelUsageItem> Models { get; set; } = [];

    /// <summary>Total de solicitudes.</summary>
    public long TotalRequests { get; set; }

    /// <summary>Total de tokens de entrada.</summary>
    public long TotalInputTokens { get; set; }

    /// <summary>Total de tokens de salida.</summary>
    public long TotalOutputTokens { get; set; }

    /// <summary>Importe total facturable.</summary>
    public decimal TotalAmount { get; set; }
}
