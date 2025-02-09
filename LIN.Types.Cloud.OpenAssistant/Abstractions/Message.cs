namespace LIN.Types.Cloud.OpenAssistant.Abstractions;

public class Message
{

    /// <summary>
    /// Rol.
    /// </summary>
    public Roles Rol { get; set; }

    /// <summary>
    /// Contenido del mensaje.
    /// </summary>
    public string Content { get; set; } = string.Empty;


    /// <summary>
    /// Nuevo mensaje de sistema.
    /// </summary>
    /// <param name="content">Contenido.</param>
    public static Message FromSystem(string content) => New(content, Roles.System);


    /// <summary>
    /// Nuevo mensaje de usuario.
    /// </summary>
    /// <param name="content">Contenido.</param>
    public static Message FromUser(string content) => New(content, Roles.User);


    /// <summary>
    /// Nuevo mensaje desde el asistente.
    /// </summary>
    /// <param name="content">Contenido.</param>
    public static Message FromAssistant(string content) => New(content, Roles.Assistant);


    /// <summary>
    /// Nuevo mensaje.
    /// </summary>
    /// <param name="content">Contenido.</param>
    /// <param name="rol">Rol.</param>
    public static Message New(string content, Roles rol)
    {
        return new()
        {
            Content = content,
            Rol = rol,
        };
    }

}