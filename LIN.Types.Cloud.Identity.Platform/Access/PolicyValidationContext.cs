namespace LIN.Types.Cloud.Identity.Platform.Access;

/// <summary>
/// Contexto contra el que el motor evalúa las <see cref="AccessPolicy"/> candidatas de una
/// organización. <see cref="AtUtc"/> nulo se resuelve a <see cref="DateTime.UtcNow"/> en el motor
/// (permite fijar la hora en tests o validar "¿hubiera pasado esto a tal hora?").
/// </summary>
public record PolicyValidationContext(
    int IdentityId,
    int OrganizationId,
    int? ApplicationId,
    string? IdentityType,
    string? IpAddress,
    string? CountryCode,
    DateTime? AtUtc);
