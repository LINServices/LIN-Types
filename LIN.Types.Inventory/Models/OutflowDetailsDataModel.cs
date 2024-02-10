using System.ComponentModel.DataAnnotations.Schema;

namespace LIN.Types.Inventory.Models;

public class OutflowDetailsDataModel 
{

    public int ID { get; set; } = 0;

    public int Cantidad { get; set; }



    public ProductDetailModel ProductDetail { get; set; } = null!;

    public int ProductDetailId { get; set; }



    public OutflowDataModel Movement { get; set; }


    public int MovementId { get; set; }

}
