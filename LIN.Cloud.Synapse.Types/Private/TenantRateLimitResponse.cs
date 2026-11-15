namespace LIN.Cloud.Synapse.Types.Private;

/// <summary>Estado del límite de solicitudes de un tenant.</summary>
public class TenantRateLimitResponse
{
    /// <summary>Límite de solicitudes por minuto.</summary>
    public int LimitPerMinute { get; set; }

    /// <summary>Solicitudes usadas en la ventana actual; null si Redis no responde.</summary>
    public long? UsedInCurrentWindow { get; set; }

    /// <summary>Inicio de la ventana actual (minuto UTC truncado).</summary>
    public DateTime WindowStartUtc { get; set; }

    /// <summary>Instante en que se reinicia la ventana (WindowStartUtc + 1 minuto).</summary>
    public DateTime WindowResetsAtUtc { get; set; }
}
