using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LNTKKiosk.Data
{
    public class RecipeData : EntityData<Recipe>
    {
        public Recipe Get(int productId, int groceryId)
        {
            LNTKEntities context = CreateContext();

            return context.Recipes.FirstOrDefault(a => a.ProductId == productId && a.GroceryId == groceryId);
        }

        public List<Recipe> GetByProductIdWithProperties(int? productId)
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.Recipes
                        select new { Recipe = x, ProductName = x.Product.Name, GroceryName = x.Grocery.Item };

            if (productId.HasValue)
                query = query.Where(x => x.Recipe.ProductId == productId);
            
            var items = query.ToList();

            foreach (var item in items)
            {
                item.Recipe.ProductName = item.ProductName;
                item.Recipe.GroceryName = item.GroceryName;
            }

            return items.ConvertAll(x => x.Recipe);

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

        public List<Recipe> GetAllWithProperties()
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.Recipes
                        select new { Recipe = x, ProductName = x.Product.Name, GroceryName = x.Grocery.Item };

            var items = query.ToList();

            foreach (var item in items)
            {
                item.Recipe.ProductName = item.ProductName;
                item.Recipe.GroceryName = item.GroceryName;
            }

            return items.ConvertAll(x => x.Recipe);

        }
    }
}
