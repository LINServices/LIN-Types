namespace LIN.Types.Notes.Transient;

public class IntegrantDataModel
{

    public int ID { get; set; } = 0;
    public int InventoryID { get; set; } = 0;
    public int ProfileID { get; set; } = 0;
    public int AccessID { get; set; } = 0;
    public string Nombre { get; set; } = string.Empty;
    public byte[] Perfil { get; set; } = [];
    public string Usuario { get; set; } = string.Empty;
    public NoteAccessState State { get; set; }

}