using LIN.Shared.Enumerations;

namespace LIN.Shared.Models;

public class IntegrantDataModel
{

    public int ID { get; set; } = 0;
    public int InventoryAccessID { get; set; } = 0;
    public int AccessID { get; set; } = 0;
    public string Nombre { get; set; } = string.Empty;
    public byte[] Perfil { get; set; } = Array.Empty<byte>();
    public string Usuario { get; set; } = string.Empty;
    public InventoryRols Rol { get; set; } = InventoryRols.Undefined;



    public static explicit operator UserDataModel(IntegrantDataModel? identificador)
    {
        return new UserDataModel()
        {
            ID = identificador?.ID ?? 0,
           Nombre = identificador?.Nombre ?? "",
           Perfil = identificador?.Perfil ?? Array.Empty<byte>(),
           Usuario = identificador?.Usuario ?? ""
        };
    }



}
