namespace LIN.Cloud.Synapse.Types.Private;

/// <summary>Modelo visto desde un tenant concreto.</summary>
public class TenantModelResponse
{
    /// <summary>Identificador del modelo.</summary>
    public string ModelId { get; set; } = string.Empty;

    /// <summary>Proveedor del modelo.</summary>
    public string Provider { get; set; } = string.Empty;

    /// <summary>Descripción del modelo.</summary>
    public string? Description { get; set; }

    /// <summary>Capacidades del modelo.</summary>
    public LIN.Cloud.Synapse.Types.Enums.ModelCapability Capabilities { get; set; }

    /// <summary>Precio vigente de entrada por millón de tokens; null si no hay precio.</summary>
    public decimal? InputPricePerMillionTokens { get; set; }

    /// <summary>Precio vigente de salida por millón de tokens; null si no hay precio.</summary>
    public decimal? OutputPricePerMillionTokens { get; set; }

    /// <summary>Indica si el tenant puede usar el modelo.</summary>
    public bool IsAllowed { get; set; }

    /// <summary>Estado del modelo para el tenant.</summary>
    public TenantModelStatus Status { get; set; }
}
