namespace LIN.Types.Inventory.Models;

public class IntegrantDataModel
{
    public int Id { get; set; } = 0;
    public int InventoryId { get; set; } = 0;
    public int ProfileId { get; set; } = 0;
    public int AccessId { get; set; } = 0;
    public string Nombre { get; set; } = string.Empty;
    public byte[] Perfil { get; set; } = Array.Empty<byte>();
    public string Usuario { get; set; } = string.Empty;
    public InventoryRoles Rol { get; set; } = InventoryRoles.Undefined;
    public InventoryAccessState State { get; set; }
}