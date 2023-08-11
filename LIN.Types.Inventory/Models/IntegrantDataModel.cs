using LIN.Types.Inventory.Enumerations;

namespace LIN.Types.Inventory.Models;

public class IntegrantDataModel
{

    public int ID { get; set; } = 0;
    public int InventoryAccessID { get; set; } = 0;
    public int AccessID { get; set; } = 0;
    public string Nombre { get; set; } = string.Empty;
    public byte[] Perfil { get; set; } = Array.Empty<byte>();
    public string Usuario { get; set; } = string.Empty;
    public InventoryRoles Rol { get; set; } = InventoryRoles.Undefined;



    public static explicit operator ProfileModel(IntegrantDataModel? identificador)
    {
        return new ProfileModel()
        {
            ID = identificador?.ID ?? 0,
            Nombre = identificador?.Nombre ?? "",
            Perfil = identificador?.Perfil ?? Array.Empty<byte>(),
            Usuario = identificador?.Usuario ?? ""
        };
    }



}
