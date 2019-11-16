using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Serie2y3.CLASES
{
    public class Pizza
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Masa")]
        public string[] Ingredientes { get; set; }
        public string Masa { get; set; }
        public string Size { get; set; }
        public int Porciones { get; set; }
        public bool ExtraQueso { get; set; }
    }
}
