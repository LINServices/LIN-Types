namespace LIN.Types.Cloud.Edge.Models;

public class RegionDataModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public List<ServerDataModel> Servers { get; set; } = [];
}

public class ServerDataModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string HostIp { get; set; } = string.Empty;
    public string HostName { get; set; } = string.Empty;
    public List<ServerFeature> ServerFeatures { get; set; } = [];
    public int RegionId { get; set; }
    public RegionDataModel Region { get; set; } = new RegionDataModel();
}

public class ServerFeature
{
    public string Feature { get; set; } = string.Empty;
    public ServerDataModel ServerData { get; set; } = new ServerDataModel();
    public int ServerDataId { get; set; }
}

public static class ServerConstants
{
    public const string FeatureNet = "dotnet";
    public const string FeatureWeb = "web";
    public const string FeatureNode = "node";
    public const string FeatureMongo = "mongo";
    public const string FeaturePostgres = "postgres";
    public const string FeatureMySql = "mysql";
    public const string FeatureRedis = "redis";
    public const string FeatureValkey = "valkey";
    public const string FeatureProxy = "proxy";
    public const string FeatureRabbit = "rabbit";
    public const string FeatureGateway = "gateway";
    public const string FeaturePublish = "publish";
    public const string FeatureMiniIo = "miniio";
}