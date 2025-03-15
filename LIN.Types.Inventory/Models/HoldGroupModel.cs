namespace LIN.Types.Inventory.Models;

public class HoldGroupModel
{
    public int Id { get; set; }
    public DateTime Expiration { get; set; }
    public List<HoldModel> Holds { get; set; } = [];
}