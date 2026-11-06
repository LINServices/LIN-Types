using LIN.Types.Cloud.Edge.Enums;

namespace LIN.Types.Cloud.Edge.Models;

/// <summary>
/// Solicitud para publicar una actualización en el catálogo. Un solo constructor público: se enlaza desde el cuerpo HTTP.
/// </summary>
/// <param name="ResourceType">Tipo de recurso normalizado (postgre.db, mysql, dotnet...).</param>
public sealed record CreateUpdateEntryRequest(string ResourceType, string Title, string? Notes);
