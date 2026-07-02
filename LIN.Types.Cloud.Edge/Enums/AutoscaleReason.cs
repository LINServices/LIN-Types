namespace LIN.Types.Cloud.Edge.Enums;

/// <summary>
/// Motivo principal del estado de autoescalado, para que el cliente pueda explicar
/// por qué se está (o no se está) escalando.
/// </summary>
public enum AutoscaleReason
{
    /// <summary>Autoescalado apagado (techo Auto en 0) y sin réplicas Auto que retirar.</summary>
    Disabled,

    /// <summary>Autoescalado apagado: se están retirando las réplicas Auto existentes.</summary>
    DisabledDraining,

    /// <summary>No existe instancia base de producción; no se gestiona autoescalado.</summary>
    NoBaseInstance,

    /// <summary>No hay métricas suficientes en la ventana para tomar una decisión.</summary>
    InsufficientMetrics,

    /// <summary>Estado estable: la cantidad de réplicas Auto es la adecuada para la carga.</summary>
    Stable,

    /// <summary>Presión alta pero ya se alcanzó el techo Auto: no se pueden crear más réplicas.</summary>
    AtMaxCeiling,

    /// <summary>Se desea un cambio pero está bloqueado temporalmente por el cooldown de escalado.</summary>
    CooldownActive,

    /// <summary>Escalando hacia arriba (creando réplicas Auto).</summary>
    ScalingUp,

    /// <summary>Escalando hacia abajo (retirando réplicas Auto).</summary>
    ScalingDown
}
