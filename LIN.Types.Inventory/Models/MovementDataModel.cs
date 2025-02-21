namespace LIN.Types.Inventory.Models;

public abstract class MovementDataModel<DetailsModel> where DetailsModel : class
{

    [Column("Id")]
    public int Id { get; set; } = 0;

    [Column("MovementDate")]
    public DateTime Date { get; set; }
    public InventoryDataModel Inventory { get; set; } = null!;
    public int InventoryId { get; set; }

    [Column("PROFILE_FK")]
    public int ProfileID { get; set; }
    public ProfileModel Profile { get; set; } = null!;
    public List<DetailsModel> Details { get; set; } = [];
    [NotMapped]
    public int CountDetails { get; set; } = 0;
    [NotMapped]
    public decimal Inversion { get; set; } = 0;

}