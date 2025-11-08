namespace LIN.Types.Inventory.Models;

public class OutflowDataModel : MovementDataModel<OutflowDetailsDataModel>
{
    public OutflowsTypes Type { get; set; }
    public InflowDataModel? InflowRelated { get; set; }
    public int? InflowRelatedId { get; set; }

    [NotMapped]
    public decimal Ganancia { get; set; } = 0;

    [NotMapped]
    public decimal Utilidad { get; set; } = 0;
}