using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace Recipes.Dao.mongodb
{
    public class RecipeDto
    {

        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string  Id { get; set; }
        string Title { set; get; }
        public string Author { get; set; }
        public List<string> Igredients { get; set; }
        public string Steps { get; set; }



    }
}
