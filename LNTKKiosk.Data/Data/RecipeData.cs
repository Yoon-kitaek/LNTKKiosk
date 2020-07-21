using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class RecipeData : EntityData<Recipe>
    {
        public Recipe Get(int productId, int groceryId)
        {
            LNTKEntities context = CreateContext();

            return context.Recipes.FirstOrDefault(a => a.ProductId == productId && a.GroceryId == groceryId);
        }

        public void Delete(int productId, int groceryId)
        {
            Recipe recipe = Get(productId, groceryId);

            if (recipe == null)
                return;

            Delete(recipe);
        }

        public List<Recipe> GetByProduct(int productId)
        {
            List<Recipe> recipes = DataRepository.Recipe.GetAll();

            recipes.RemoveAll(x => x.ProductId != productId);

            return recipes;
        }
    }
}
