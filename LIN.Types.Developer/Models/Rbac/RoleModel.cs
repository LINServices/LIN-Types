namespace LIN.Types.Developer.Models.Rbac;

public class RoleModel
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Indica si el rol es interno (gestionado por la plataforma) o personalizado.
    /// </summary>
    public bool IsInternal { get; set; }

    /// <summary>
    /// Recurso al que pertenece el rol. Aplica principalmente para roles personalizados.
    /// </summary>
    public int? ResourceId { get; set; }
}