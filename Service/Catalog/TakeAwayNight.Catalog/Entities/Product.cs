using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TakeAwayNight.Catalog.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public string ProducId { get; set; }
        public string ProducName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
