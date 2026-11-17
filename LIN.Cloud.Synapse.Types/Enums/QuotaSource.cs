namespace LIN.Cloud.Synapse.Types.Enums;

/// <summary>
/// De dónde sale un límite de tokens efectivo de un tenant sobre un modelo y periodo.
/// </summary>
public enum QuotaSource
{
    /// <summary>
    /// Límite propio del tenant (anula el del modelo en ese periodo).
    /// </summary>
    Tenant = 0,

    /// <summary>
    /// Límite por defecto del modelo, aplicado porque el tenant no tiene uno propio en ese periodo.
    /// </summary>
    ModelDefault = 1
}
