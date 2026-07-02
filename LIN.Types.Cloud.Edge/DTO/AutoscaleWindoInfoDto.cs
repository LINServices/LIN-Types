using LIN.Types.Cloud.Edge.Enums;

namespace LIN.Types.Cloud.Edge.DTO;

public sealed class AutoscaleStatusDto
{
    /// <summary>Autoescalado habilitado (techo Auto &gt; 0).</summary>
    public bool Enabled { get; set; }

    /// <summary>Motivo principal del estado actual.</summary>
    public AutoscaleReason Reason { get; set; }

    // --- Ventana de evaluación ---

    /// <summary>Inicio de la ventana de métricas evaluada (UTC).</summary>
    public DateTime WindowFrom { get; set; }

    /// <summary>Fin de la ventana de métricas evaluada (UTC, "ahora").</summary>
    public DateTime WindowTo { get; set; }

    /// <summary>Tamaño de la ventana en segundos (Autoscale:WindowSeconds).</summary>
    public int WindowSeconds { get; set; }

    // --- Uso observado en la ventana (ratios 0..1) ---

    /// <summary>Hubo métricas suficientes (SampleCount &gt;= MinSamples) para decidir.</summary>
    public bool HasMetrics { get; set; }

    /// <summary>Cantidad de muestras consideradas en la ventana.</summary>
    public long SampleCount { get; set; }

    /// <summary>Utilización dominante del grupo: el máximo entre CPU y memoria.</summary>
    public double Utilization { get; set; }

    /// <summary>Utilización de CPU del grupo (0..1).</summary>
    public double CpuUtilization { get; set; }

    /// <summary>Utilización de memoria del grupo (0..1).</summary>
    public double MemoryUtilization { get; set; }

    // --- Umbrales de decisión (ratios 0..1) ---

    /// <summary>Utilización objetivo (divisor de la fórmula HPA).</summary>
    public double TargetUtilization { get; set; }

    /// <summary>Umbral máximo: por encima se escala hacia arriba.</summary>
    public double ScaleUpThreshold { get; set; }

    /// <summary>Umbral mínimo: por debajo se escala hacia abajo.</summary>
    public double ScaleDownThreshold { get; set; }

    /// <summary>Muestras mínimas requeridas en la ventana para decidir.</summary>
    public int MinSamples { get; set; }

    // --- Conteo de instancias de producción ---

    /// <summary>Instancias base (siempre 1 cuando el recurso está aprovisionado).</summary>
    public int BaseCount { get; set; }

    /// <summary>Réplicas fijas (definidas por el usuario, consumen cupo del plan).</summary>
    public int FixedCount { get; set; }

    /// <summary>Réplicas de autoescalado actualmente activas.</summary>
    public int CurrentAuto { get; set; }

    /// <summary>Techo de réplicas de autoescalado (0 = apagado).</summary>
    public int MaxAuto { get; set; }

    /// <summary>Total de instancias activas consideradas para el uso (base + fijas + auto).</summary>
    public int ActiveInstances { get; set; }

    // --- Decisión ---

    /// <summary>Cantidad de réplicas Auto que la carga actual justifica (ya acotada a [0, MaxAuto]).</summary>
    public int DesiredAuto { get; set; }

    /// <summary>Indica si <see cref="DesiredAuto"/> difiere de <see cref="CurrentAuto"/>.</summary>
    public bool WouldChange { get; set; }

    /// <summary>Hay un cooldown de escalado activo que bloquea nuevas acciones.</summary>
    public bool InCooldown { get; set; }

    /// <summary>Duración del cooldown de escalado en segundos (Autoscale:ScaleCooldownSeconds).</summary>
    public int ScaleCooldownSeconds { get; set; }
}
