using System.Text.Json.Serialization;

namespace LIN.Types.Developer.Models;


public class AccessModel
{
   [JsonPropertyName("profile_id")]
    [BsonElement("profile_id")]
    [Column("profile_id")]
    
    public int Profile { get; set; }

 [JsonPropertyName("level")]
    [BsonElement("level")]
    [Column("level")]
   
    public IamLevels IamLevel { get; set; }

}
