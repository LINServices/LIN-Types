namespace Http.Models;

public class PaginationQuery
{

    /// <summary>
    /// Limite de registros.
    /// </summary>
    public int Limit { get; set; }


    /// <summary>
    /// Ultimo Id.
    /// </summary>
    public int LastId { get; set; }


    /// <summary>
    /// Obtener una instancia sin paginación.
    /// </summary>
    public static PaginationQuery Unlimited()
    {
        return new PaginationQuery() { Limit = int.MaxValue, LastId = 0 };
    }


    /// <summary>
    /// Paginación.
    /// </summary>
    public static PaginationQuery From(int limit, int lastId = 0) => new() { Limit = limit, LastId = lastId };

}