namespace LIN.Cloud.Synapse.Types.Private;

/// <summary>Uso agregado de un modelo por un tenant.</summary>
public class TenantModelUsageItem
{
    /// <summary>Identificador del modelo.</summary>
    public string ModelId { get; set; } = string.Empty;

    /// <summary>Número de solicitudes.</summary>
    public long RequestCount { get; set; }

    /// <summary>Tokens de entrada.</summary>
    public long InputTokens { get; set; }

    /// <summary>Tokens de salida.</summary>
    public long OutputTokens { get; set; }

    /// <summary>Importe facturable del uso.</summary>
    public decimal Amount { get; set; }
}
