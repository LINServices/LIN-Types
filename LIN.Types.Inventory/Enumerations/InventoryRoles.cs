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
    /// Supervisor de inventario.
    /// </summary>
    Supervisor,

    /// <summary>
    /// Integrante de inventario.
    /// </summary>
    Member,

    /// <summary>
    /// Invitado
    /// </summary>
    Guest,

    /// <summary>
    /// Lector de inventarios.
    /// </summary>
    Reader,

    /// <summary>
    /// Eliminado del acceso (Sin permisos)
    /// </summary>
    Banned,

}