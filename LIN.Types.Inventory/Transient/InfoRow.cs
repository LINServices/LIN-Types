namespace LIN.Types.Inventory.Transient;


public class InfoRow
{

    public int ProductId { get; set; }
    public string ProductCode { get; set; } = string.Empty;
    public string ProductName { get; set; } = string.Empty;
    public decimal PrecioCompra { get; set; }
    public decimal PrecioVenta { get; set; }
    public DateTime Fecha { get; set; }
    public int Cantidad { get; set; }


}


public class InflowRow : InfoRow
{
    public InflowsTypes Type { get; set; }
}


public class OutflowRow : InfoRow
{
    public OutflowsTypes Type { get; set; }
}



