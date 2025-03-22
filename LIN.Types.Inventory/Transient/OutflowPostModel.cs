using LIN.Types.Inventory.Models;

namespace LIN.Types.Inventory.Transient;

public class OutflowPostModel
{
    public OutflowDataModel Movement { get; set; }
    public bool WithOutsider { get; set; }
    public OutsiderModel Outsider { get; set; }
}