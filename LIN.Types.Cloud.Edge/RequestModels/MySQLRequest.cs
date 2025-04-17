namespace LIN.Types.Cloud.Edge.RequestModels;

public class MySqlRequestModel
{
    public string Name { get; set; }           // Nombre lógico del contenedor
    public string DatabaseName { get; set; }   // Nombre de la BD inicial
    public string DefaultUser { get; set; }    // Usuario creado adicional
    public string Password { get; set; }       // Password para ese usuario
    public string RootPassword { get; set; }   // Root password obligatorio
}
