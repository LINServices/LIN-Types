namespace LIN.Types.Inventory.Models;

public class InventoryAccessDataModel
{
    public int Id { get; set; } = 0;
    public InventoryRoles Rol { get; set; }

    [Column("ESTADO")]
    public InventoryAccessState State { get; set; }
    public DateTime Fecha { get; set; }

    [Column("PROFILE_FK")]
    public int ProfileId { get; set; }

    [Column("INVENTARIO_FK")]
    public int Inventario { get; set; }
}