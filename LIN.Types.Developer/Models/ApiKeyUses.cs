namespace LIN.Types.Developer.Models;


public class ApiKeyUsesDataModel
{

    public int ID { get; set; }

    public ApiKeyDataModel Key { get; set; }

    public TransactionDataModel Transaction { get; set; }

    [NotMapped]
    public decimal Valor { get; set; }


}