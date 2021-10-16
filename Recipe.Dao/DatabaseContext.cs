using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Dao.mongodb
{
    class DatabaseContext : IDatabaseContext
    {
        public IMongoCollection<RecipeDto> Recipies { get; }

        public DatabaseContext()
        {
            IMongoClient client = new MongoClient("connectionString");
            IMongoDatabase mongoDatabase = client.GetDatabase("DatabaseName");
            Recipies = mongoDatabase.GetCollection<RecipeDto>("RecipiesCollection");
        }
    }
}
