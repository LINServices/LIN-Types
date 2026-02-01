namespace LIN.Types.Cloud.Identity.Models.Policies;

/// <summary>
/// Regla basada en el tiempo.
/// </summary>
public record TimeRule
{
    /// <summary>
    /// Días de la semana permitidos.
    /// </summary>
    public List<DayOfWeek> Days { get; set; } = [];

    /// <summary>
    /// Hora de inicio.
    /// </summary>
    public TimeOnly StartTime { get; set; }

    /// <summary>
    /// Hora de fin.
    /// </summary>
    public TimeOnly EndTime { get; set; }
}
