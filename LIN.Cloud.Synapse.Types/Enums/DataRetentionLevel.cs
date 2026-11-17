namespace LIN.Cloud.Synapse.Types.Enums;

/// <summary>
/// Qué hace el proveedor del modelo con los datos de las peticiones (prompts y respuestas).
/// </summary>
public enum DataRetentionLevel
{
    /// <summary>
    /// Nivel 0: el proveedor no retiene los datos.
    /// </summary>
    None = 0,

    /// <summary>
    /// Nivel 1: el proveedor retiene los datos solo para métricas, monitoreo o abuso; no entrena con ellos.
    /// </summary>
    Retained = 1,

    /// <summary>
    /// Nivel 2: el proveedor puede usar los datos para otros fines, como entrenar modelos.
    /// </summary>
    Training = 2
}
