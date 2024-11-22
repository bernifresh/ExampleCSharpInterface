using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ProgrammingAgainstInterfaces.Entities;

public class ExampleEntity
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; } = null!;

    [BsonElement("title")]
    public string Title { get; set; } = null!;

    [BsonElement("names")]
    public List<string> Names { get; set; } = null!;

    [BsonElement("randomNumber")]
    public double RandomNumber { get; set; }
}