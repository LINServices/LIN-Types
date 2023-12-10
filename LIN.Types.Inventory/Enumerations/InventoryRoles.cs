namespace LIN.Types.Inventory.Enumerations;


public enum InventoryRoles
{

    /// <summary>
    /// Rol no definido (Sin permisos)
    /// </summary>
    Undefined,

    /// <summary>
    /// Rol de administrador
    /// </summary>
    Administrator,

    /// <summary>
    /// Miembro del inventario
    /// </summary>
    Member,

    /// <summary>
    /// Eliminado del acceso (Sin permisos)
    /// </summary>
    Banned,

    /// <summary>
    /// Invitado
    /// </summary>
    Guest

}
