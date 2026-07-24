using System.ComponentModel.DataAnnotations;

namespace LIN.Types.VectorSearch.Dtos;

/// <summary>
/// Modificación parcial de un tenant. Lo que llega en null se deja como está.
/// </summary>
public class UpdateTenantRequest
{
    [StringLength(200)]
    public string? Name { get; set; }

    public TenantStatus? Status { get; set; }

    /// <summary>
    /// Cambiar el modelo no reindexa nada de inmediato: marca el corpus como obsoleto y el
    /// barrido en segundo plano lo recalcula por lotes. Mientras tanto las búsquedas del tenant
    /// no devuelven resultados, porque comparar contra el índice viejo daría distancias sin
    /// significado.
    /// </summary>
    [StringLength(100)]
    public string? EmbeddingModel { get; set; }

    [Range(0, int.MaxValue)]
    public int? MaxDocuments { get; set; }

    [Range(1, 100000)]
    public int? RateLimitPerMinute { get; set; }
}
