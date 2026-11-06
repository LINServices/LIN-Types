using LIN.Types.Cloud.Edge.Enums;

namespace LIN.Types.Cloud.Edge.Models;

/// <summary>
/// Entrada del catálogo con el desglose de sus targets por estado.
/// </summary>
public sealed record UpdateEntryDetailDto(UpdateEntryDto Entry, IReadOnlyDictionary<UpdateTargetState, int> TargetsByState)
{
    /// <summary>
    /// Constructor vacío requerido por <c>ReadOneResponse</c>.
    /// </summary>
    public UpdateEntryDetailDto() : this(new UpdateEntryDto(), new Dictionary<UpdateTargetState, int>()) { }
}
