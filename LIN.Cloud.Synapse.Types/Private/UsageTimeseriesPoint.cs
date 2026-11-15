namespace LIN.Cloud.Synapse.Types.Private;

/// <summary>Punto de la serie temporal de uso.</summary>
public class UsageTimeseriesPoint
{
    /// <summary>Inicio del intervalo (hora o día UTC truncado).</summary>
    public DateTime BucketStartUtc { get; set; }

    /// <summary>Número de solicitudes.</summary>
    public long RequestCount { get; set; }

    /// <summary>Tokens de entrada.</summary>
    public long InputTokens { get; set; }

    /// <summary>Tokens de salida.</summary>
    public long OutputTokens { get; set; }

    /// <summary>Importe facturable del intervalo.</summary>
    public decimal Amount { get; set; }
}
