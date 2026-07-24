using System.ComponentModel.DataAnnotations;

namespace LIN.Types.VectorSearch.Dtos;

/// <summary>
/// Alta de un tenant desde el API de administración.
/// </summary>
public class CreateTenantRequest
{
    /// <summary>
    /// ResourceId del recurso de LIN Platform. Lo provee quien administra, no lo genera este
    /// servicio: el tenant ya existe en la plataforma antes de tener corpus aquí.
    /// </summary>
    [Range(1, int.MaxValue)]
    public int ResourceId { get; set; }

    [StringLength(200)]
    public string? Name { get; set; }

    /// <summary>
    /// Modelo de embedding del tenant. Si se omite se usa el de configuración.
    /// </summary>
    [StringLength(100)]
    public string? EmbeddingModel { get; set; }

    [Range(0, int.MaxValue)]
    public int MaxDocuments { get; set; } = 1000;

    [Range(1, 100000)]
    public int RateLimitPerMinute { get; set; } = 60;
}
