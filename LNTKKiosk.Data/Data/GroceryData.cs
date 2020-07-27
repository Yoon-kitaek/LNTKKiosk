using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class GroceryData : EntityData<Grocery>
    {
        public Grocery Get(int groceryId)
        {
            LNTKEntities context = CreateContext();

            return context.Groceries.FirstOrDefault(a => a.GroceryId == groceryId);
        }

        public void Delete(int groceryId)
        {
            Grocery grocery = Get(groceryId);

            if (grocery == null)
                return;

            Delete(grocery);
        }

        public int GetMaxId()
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.Groceries
                        orderby x.GroceryId descending
                        select x.GroceryId;

            return query.FirstOrDefault();
        }

        public List<Grocery> GetAllWithProperties()
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.Groceries
                        select new { Grocery = x, CategoryName = x.CodeCategory.Item };

            var items = query.ToList();

            foreach (var item in items)
            {
                item.Grocery.CategoryName = item.CategoryName;
            }

            return items.ConvertAll(x => x.Grocery);
        }
    }
}
