using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recipes.Domain;

namespace Recipes.Dao.Domain
{
    public interface IRecipeDao
    {

        public IEnumerable<Recipe> GetRecipes();
        public Recipe GetRecipeById(int recipeId);

        public void AddRecipe(Recipe recipeToAdd);

    }
}
