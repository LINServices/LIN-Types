namespace LIN.Cloud.Synapse.Types.Private;

/// <summary>Resumen general de un tenant.</summary>
public class TenantOverviewResponse
{
    /// <summary>Identificador del recurso (tenant).</summary>
    public int ResourceId { get; set; }

    /// <summary>Estado del tenant.</summary>
    public LIN.Cloud.Synapse.Types.Enums.TenantStatus Status { get; set; }

    /// <summary>Límite de solicitudes por minuto.</summary>
    public int RateLimitPerMinute { get; set; }

    /// <summary>Fecha de creación (UTC).</summary>
    public DateTime CreatedAt { get; set; }
}
