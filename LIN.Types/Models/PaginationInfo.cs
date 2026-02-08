namespace LIN.Types.Models;

/// <summary>
/// Información de paginación para respuestas de lectura
/// </summary>
public class PaginationInfo
{
    /// <summary>
    /// Número de página actual (comenzando en 1)
    /// </summary>
    public int CurrentPage { get; set; } = 1;

    /// <summary>
    /// Total de elementos en la consulta completa
    /// </summary>
    public long TotalElements { get; set; } = 0;

    /// <summary>
    /// Tamaño de página (cantidad de elementos por página)
    /// </summary>
    public int PageSize { get; set; } = 0;

    /// <summary>
    /// Total de páginas disponibles (calculado)
    /// </summary>
    public int TotalPages => PageSize > 0 ? (int)Math.Ceiling((double)TotalElements / PageSize) : 0;

    /// <summary>
    /// Último ID numérico recuperado (para paginación con cursores numéricos)
    /// </summary>
    public int? LastId { get; set; }

    /// <summary>
    /// Último ID único/GUID recuperado (para paginación con cursores de string/GUID v7)
    /// </summary>
    public string? LastUniqueId { get; set; }

    /// <summary>
    /// Constructor vacío
    /// </summary>
    public PaginationInfo() { }

    /// <summary>
    /// Constructor con información básica de paginación
    /// </summary>
    public PaginationInfo(int currentPage, long totalElements, int pageSize = 0)
    {
        CurrentPage = currentPage;
        TotalElements = totalElements;
        PageSize = pageSize;
    }

    /// <summary>
    /// Constructor completo con índices
    /// </summary>
    public PaginationInfo(int currentPage, long totalElements, int pageSize, int? lastId, string? lastUniqueId)
    {
        CurrentPage = currentPage;
        TotalElements = totalElements;
        PageSize = pageSize;
        LastId = lastId;
        LastUniqueId = lastUniqueId;
    }
}
