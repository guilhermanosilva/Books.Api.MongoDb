using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace BooksApiMongoDb.Models
{
    public class Book
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        public string Author { get; set; }
        
        public string Editor { get; set; }
        
        public string BookName { get; set; }
        
        public string Language { get; set; }

        public string ISBN { get; set; }
        
        public string Dimensions { get; set; }
        
        public decimal Price { get; set; }
    }
}