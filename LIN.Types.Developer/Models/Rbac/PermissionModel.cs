namespace LIN.Types.Developer.Models.Rbac;

public class PermissionModel
{
    public int Id { get; set; }

    /// <summary>
    /// Valor del permiso en formato "resource:action", por ejemplo "invoice:delete".
    /// </summary>
    public string Value { get; set; } = string.Empty;

    /// <summary>
    /// Descripción legible del permiso.
    /// </summary>
    public string Description { get; set; } = string.Empty;
}