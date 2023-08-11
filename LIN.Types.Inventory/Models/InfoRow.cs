using LIN.Types.Inventory.Enumerations;

namespace LIN.Types.Inventory.Models;


public class InfoRow
{

    public string ProductCode { get; set; }
    public string ProductName { get; set; }
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



