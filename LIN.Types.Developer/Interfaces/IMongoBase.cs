namespace LIN.Types.Developer.Interfaces;


public interface IMongoBase
{

    [BsonId]
    [BsonElement("_id")]
    public ObjectId Id { get; set; }

}