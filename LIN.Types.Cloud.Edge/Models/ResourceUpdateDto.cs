using LIN.Types.Cloud.Edge.Enums;

namespace LIN.Types.Cloud.Edge.Models;

/// <summary>
/// Actualización pendiente de un contenedor, tal como la ve el dueño del recurso.
/// </summary>
/// <param name="ImageNewer">El daemon del servidor tiene una imagen más nueva que la del contenedor.</param>
public sealed record ResourceUpdateDto(int TargetId, int EntryId, string Title, string? Notes, int ContainerId, UpdateTargetState State, bool ImageNewer, string? Message, int Attempts)
{
    /// <summary>
    /// Constructor vacío requerido por <c>ReadOneResponse</c>.
    /// </summary>
    public ResourceUpdateDto() : this(0, 0, string.Empty, null, 0, UpdateTargetState.Pending, false, null, 0) { }
}
