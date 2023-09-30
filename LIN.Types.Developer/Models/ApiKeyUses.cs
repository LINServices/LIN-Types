namespace LIN.Types.Developer.Models;


public class ApiKeyUsesDataModel
{

    public int ID { get; set; }

    public int KeyID { get; set; }

    public int TransactionID { get; set; }

    [NotMapped]
    public decimal Valor { get; set; }


}