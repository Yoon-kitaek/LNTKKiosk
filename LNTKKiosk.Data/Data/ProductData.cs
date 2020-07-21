using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class ProductData : EntityData<Product>
    {
        public List<Product> SearchByCategory(string category)
        {
            var context = CreateContext();

            return context.Products.Where(x => x.Name.Contains(category)).ToList();
        }
    }
}
