namespace LIN.Types.Inventory.Models;

public abstract class MovementDataModel<DetailsModel> where DetailsModel : class
{
    public int Id { get; set; } = 0;
    public DateTime Date { get; set; }
    public MovementStatus Status { get; set; }
    public InventoryDataModel Inventory { get; set; } = null!;
    public int InventoryId { get; set; }
    public OrderModel? Order { get; set; }
    public int? OrderId { get; set; }
    public int? ProfileId { get; set; }
    public ProfileModel? Profile { get; set; } = null!;
    public List<DetailsModel> Details { get; set; } = [];

    [NotMapped]
    public int CountDetails { get; set; } = 0;
    [NotMapped]
    public decimal Inversion { get; set; } = 0;

}