namespace LIN.Types.Inventory.Transient;


public class HomeDto
{

    public decimal TodaySalesTotal { get; set; }
    public decimal YesterdaySalesTotal { get; set; }

    public decimal WeekSalesTotal { get; set; }
    public decimal LastWeekSalesTotal { get; set; }

    public List<SalesModel> WeekSales { get; set; } = [];

}
