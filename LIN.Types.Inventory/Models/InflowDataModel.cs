namespace LIN.Types.Inventory.Models;

public class InflowDataModel : MovementDataModel<InflowDetailsDataModel>
{
    public bool IsAccepted { get; set; }
    public InflowsTypes Type { get; set; }

    public OutflowDataModel? OutflowRelated { get; set; }
    public int? OutflowRelatedId { get; set; }

    [NotMapped]
    public decimal Prevision { get; set; }
}