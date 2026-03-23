namespace LIN.Types.Cloud.Edge.Enums;

public enum ScalingType
{
    /// <summary>
    /// Número fijo de instancias definidas manualmente.
    /// </summary>
    Fixed = 0,

    /// <summary>
    /// Escalado automático basado en demanda (CPU, tráfico, etc).
    /// </summary>
    Auto = 1
}