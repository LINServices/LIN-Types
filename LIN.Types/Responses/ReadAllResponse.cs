using LIN.Types.Models;

namespace LIN.Types.Responses;

public class ReadAllResponse<M> : ResponseBase
{

    /// <summary>
    /// Lista de modelos
    /// </summary>
    public List<M> Models { get; set; }

    /// <summary>
    /// Información de paginación
    /// </summary>
    public PaginationInfo Pagination { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    public ReadAllResponse()
    {
        Response = Responses.Undefined;
        Models = [];
        Pagination = new PaginationInfo();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    public ReadAllResponse(Responses response = Responses.Undefined)
    {
        Response = response;
        Models = [];
        Pagination = new PaginationInfo();
    }

    /// <summary>
    /// Constructor
    /// </summary>
    public ReadAllResponse(Responses response, IEnumerable<M> models)
    {
        Response = response;
        Models = models.ToList() ?? [];
        Pagination = new PaginationInfo();
    }

    /// <summary>
    /// Constructor con paginación
    /// </summary>
    public ReadAllResponse(Responses response, IEnumerable<M> models, PaginationInfo pagination)
    {
        Response = response;
        Models = models.ToList() ?? [];
        Pagination = pagination ?? new PaginationInfo();
    }

    /// <summary>
    /// Constructor con paginación completa
    /// </summary>
    public ReadAllResponse(Responses response, IEnumerable<M> models, int currentPage, long totalElements, int pageSize = 0, int? lastId = null, string? lastUniqueId = null)
    {
        Response = response;
        Models = models.ToList() ?? [];
        Pagination = new PaginationInfo(currentPage, totalElements, pageSize, lastId, lastUniqueId);
    }
}