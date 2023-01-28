using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Catlog.Api.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } // as it will be in bson id 


        [BsonElement("Name")]
        public string Name { get; set; }
        public string Description { get; set; }

        public string Summary { get; set; }
        public string Category { get; set; }

        public string ImageFile { get; set; }

        public decimal Price { get; set; }
    }
}
