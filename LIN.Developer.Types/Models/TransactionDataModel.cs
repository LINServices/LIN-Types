using LIN.Developer.Types.Enumerations;

namespace LIN.Developer.Types.Models;


public class TransactionDataModel
{

    public int ID { get; set; }

    public DateTime Fecha { get; set; }

    public decimal Valor { get; set; }

    public TransactionTypes Tipo { get; set; }

    public int ProfileID { get; set; }

    public string Description { get; set; } = string.Empty;

}
