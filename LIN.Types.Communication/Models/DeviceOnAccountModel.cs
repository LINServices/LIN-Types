namespace LIN.Types.Communication.Models;

public class DeviceOnAccountModel
{
    public string ConnectionId { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;

    public Types.Enumerations.Platforms Platform { get; set; }
    public Types.Enumerations.Browsers Browser { get; set; }
    public Types.Enumerations.SurfaceFrom SurfaceFrom { get; set; }
}