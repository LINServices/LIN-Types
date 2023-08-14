namespace LIN.Types.Auth.Models;


public class DeviceModel
{

    public string ID { get; set; } = string.Empty;
    public string DeviceKey { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string OsVersion { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    public string Token { get; set; } = string.Empty;
    public string Manufacter { get; set; } = string.Empty;
    public int BateryLevel { get; set; }
    public bool BateryConected { get; set; }
    public int Cuenta { get; set; }
    public double Logitud { get; set; }
    public double Latitud { get; set; }
    public dynamic Platform { get; set; } = 0;
    public DeviceState Estado { get; set; } = DeviceState.Actived;
    public Applications App { get; set; } = Applications.Undefined;


    public static bool operator ==(DeviceModel? a, DeviceModel? b)
    {
        return a?.ID == b?.ID;
    }


    public static bool operator !=(DeviceModel a, DeviceModel b)
    {
        return a.ID != b.ID;
    }


    public static bool Si(DeviceModel a, DeviceModel b)
    {
        return a.ID != b.ID;
    }

    public override bool Equals(object? obj)
    {

        if (ReferenceEquals(this, obj))
            return true;


        if (obj is null)
            return false;

        return false;
    }



    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
