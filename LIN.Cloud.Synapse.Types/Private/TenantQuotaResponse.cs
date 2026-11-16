using LIN.Cloud.Synapse.Types.Enums;

namespace LIN.Cloud.Synapse.Types.Private;

/// <summary>Límite de tokens de un tenant sobre un modelo en un periodo, con el consumo de la ventana actual.</summary>
public class TenantQuotaResponse
{
    /// <summary>Id público del modelo.</summary>
    public string ModelId { get; set; } = string.Empty;

    /// <summary>Periodo de la ventana (hora, día o mes UTC).</summary>
    public QuotaPeriod Period { get; set; }

    /// <summary>Máximo de tokens de entrada en la ventana; null si no hay límite de entrada.</summary>
    public long? MaxInputTokens { get; set; }

    /// <summary>Máximo de tokens de salida en la ventana; null si no hay límite de salida.</summary>
    public long? MaxOutputTokens { get; set; }

    /// <summary>Tokens de entrada consumidos en la ventana actual; null si no se pudo leer.</summary>
    public long? UsedInputTokens { get; set; }

    /// <summary>Tokens de salida consumidos en la ventana actual; null si no se pudo leer.</summary>
    public long? UsedOutputTokens { get; set; }

    /// <summary>Inicio de la ventana actual (UTC).</summary>
    public DateTime WindowStartUtc { get; set; }

    /// <summary>Instante en que se reinicia la ventana (fin exclusivo, UTC).</summary>
    public DateTime WindowResetsAtUtc { get; set; }

    /// <summary>true si algún máximo configurado ya se alcanzó en la ventana actual.</summary>
    public bool IsExhausted { get; set; }
}
