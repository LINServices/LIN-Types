using LIN.Types.Developer.Enumerations;

namespace LIN.Types.Developer.Models;


public class TransactionDataModel
{

    public int ID { get; set; }

    public DateTime Fecha { get; set; }

    public decimal Valor { get; set; }

    public TransactionTypes Tipo { get; set; }

    public int UseID { get; set; }
    public ApiKeyUsesDataModel Use { get; set; }
    public ProfileDataModel Profile { get; set; }
    public int ProfileID { get; set; }

    public string Description { get; set; } = string.Empty;

}