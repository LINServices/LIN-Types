namespace LIN.Cloud.Synapse.Types.Private;

/// <summary>Modelo usado por un tenant en un rango de fechas.</summary>
public class UsedModelResponse
{
    /// <summary>Identificador del modelo.</summary>
    public string ModelId { get; set; } = string.Empty;

    /// <summary>Primer uso dentro del rango (UTC).</summary>
    public DateTime FirstUsedAtUtc { get; set; }

    /// <summary>Último uso dentro del rango (UTC).</summary>
    public DateTime LastUsedAtUtc { get; set; }

    /// <summary>Número de solicitudes.</summary>
    public long RequestCount { get; set; }

    /// <summary>Tokens de entrada.</summary>
    public long InputTokens { get; set; }

    /// <summary>Tokens de salida.</summary>
    public long OutputTokens { get; set; }

    /// <summary>Importe facturable del uso.</summary>
    public decimal Amount { get; set; }
}
