namespace LIN.Types.Inventory.Models;

public class OrderModel
{
    public int Id { get; set; }
    public string ExternalId { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;

    public HoldGroupModel HoldGroup { get; set; } = null!;
    public int HoldGroupId { get; set; }
}