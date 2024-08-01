﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TakeAwayNight.Catalog.Entities
{
    public class Feature
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FeatureId { get; set; }
        public string Title { get; set; }
        public string Descriptions { get; set; }

        public string Icon { get; set; }
    }
}
