using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class ChangedRecipeData : EntityData<ChangedRecipe>
    {
        public List<ChangedRecipe> GetByOrderDetailId(int orderdetailId)
        {
            var context = CreateContext();

            var query = from x in context.ChangedRecipes
                        where x.OrderDetailId == orderdetailId
                        select x;

            return query.ToList();
        }
    }
}
