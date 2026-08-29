namespace LIN.Types.Cloud.Identity.Platform.Access.Requests;

/// <summary>
/// Cuerpo de <c>POST objects/by-app-key</c>: crea un objeto autenticando con la app-key
/// (<see cref="AppKey"/> = el Guid de <c>Application.Key</c>) en vez de un token de identidad.
/// No vive en el paquete <c>LIN.Types</c> porque es un contrato propio de esta API.
/// </summary>
/// <param name="AppKey">Guid de <c>Application.Key</c>; se resuelve contra Identities.</param>
/// <param name="ResourceType">Tipo de recurso del objeto a crear.</param>
/// <param name="IdentityId">Identidad a la que se le otorgan los permisos por defecto sobre el objeto recién creado.</param>
/// <param name="OrganizationId">
/// Organización dueña del objeto (opcional). Si viene informada, <see cref="IdentityId"/> debe tener rol
/// Administrator/Manager en ella; queda registrada como <c>ObjectOwner</c>. Si es null, el objeto no tiene dueño.
/// </param>
/// <param name="ExternalRef">Referencia externa opcional (clave lógica del objeto en la app cliente).</param>
public record CreateObjectByAppKeyRequest(Guid AppKey, string Name, string ResourceType, int IdentityId, int? OrganizationId, string? ExternalRef);
