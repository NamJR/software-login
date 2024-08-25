using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace project.Models
{
    public class User
    {
        [BsonId]
        public string Id { get; set; }

        [BsonElement("email")]
        public string Email { get; set; }

        [BsonElement("password")]
        public string Password { get; set; }
    }
}
