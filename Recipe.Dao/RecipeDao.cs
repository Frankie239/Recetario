using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using Recipes.Dao.Domain;
using Recipes.Domain;

namespace Recipes.Dao.mongodb
{
    public class RecipeDao : IRecipeDao
    {
        private readonly IDatabaseContext _context;

        public RecipeDao(IDatabaseContext context)
        {
            _context = context;
        }
        public IEnumerable<Recipe> GetRecipes()
        {
            List<RecipeDto> recipes = _context.Recipies.Find(new BsonDocument()).ToList();

            return MapToDto(recipes);
        }

        private IEnumerable<Recipe> MapToDto(List<RecipeDto> recipes)
        {
            List<Recipe> convertedRecipies = new List<Recipe>();

            foreach (var recipie in recipes)
            {
                convertedRecipies.Add(MapToDto(recipie));
            }

            return convertedRecipies;

           
        }

        public Recipe GetRecipeById(int recipeId)
        {
            string filter = "{_id:{$eq: ObjectId(\"" + recipeId.ToString() + "\")}}";
            RecipeDto recipe = _context.Recipies.Find(filter).First();
            return MapToDto(recipe);
            
        }

        private Recipe MapToDto(RecipeDto recipe)
        {
            return new Recipe
            {
                Id = int.Parse(recipe.Id),
                Author = recipe.Author,
                Igredients = recipe.Igredients,
                Steps = recipe.Steps

            };
        }

        public void AddRecipe(Recipe recipeToAdd)
        {
            RecipeDto recipeDto = new RecipeDto
            {
                Id = recipeToAdd.Id.ToString(),
                Author = recipeToAdd.Author,
                Igredients = recipeToAdd.Igredients,
                Steps = recipeToAdd.Steps

            };
            _context.Recipies.InsertOne(recipeDto);
        }
    }
}
