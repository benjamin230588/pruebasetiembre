using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mongodbconexion
{
    public class producto
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string id { get; set; }
        [BsonElement("name")]
        public string name { get; set; }
        [BsonElement("edad")]
        public int edad { get; set; }

    }
}
