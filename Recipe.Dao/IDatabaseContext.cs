using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipes.Dao.mongodb
{
    public interface IDatabaseContext
    {
        IMongoCollection<RecipeDto> Recipies { get; }
    }
}
