using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class ProductData : EntityData<Product>
    {
        public Product Get(int productId)
        {
            LNTKEntities context = CreateContext();

            return context.Products.FirstOrDefault(a => a.ProductId == productId);
        }

        public void Delete(int productId)
        {
            Product product = Get(productId);

            if (product == null)
                return;

            Delete(product);
        }

        public int GetMaxId()
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.Products
                        orderby x.ProductId descending
                        select x.ProductId;

            return query.FirstOrDefault();

        }

        public List<Product> FilterbyCatergory(int codeCategoryId)
        {
            List<Product> list = DataRepository.Product.GetAll();

            return list.Where(x => x.CodeCategoryId == codeCategoryId).ToList();

        }

        public List<Product> SearchByCategory(string category)
        {
            var context = CreateContext();

            return context.Products.Where(x => x.Name.Contains(category)).ToList();
        }

        public Product GetByName(string name)
        {
            LNTKEntities context = CreateContext();

            return context.Products.FirstOrDefault(a => a.Name == name);
        }

        public int GetDiscountRate(Product product)
        {
            List<EventProduct> list = DataRepository.EventProduct.GetByProduct(product.ProductId);
            List<EventProduct> listfiltered = new List<EventProduct>();
            Event @event = new Event();
            int t = DateTime.Now.Hour * 100 + DateTime.Now.Minute;
            if (list.Count() > 0)
            {
                foreach (EventProduct eventProduct in list)
                {
                    @event = DataRepository.Event.Get(eventProduct.EventId);
                    if (t > @event.StartTime && t < @event.EndTime)
                    {
                        listfiltered.Add(eventProduct);
                    } 
                }

                if (listfiltered.Count() > 0)
                {
                    listfiltered.OrderByDescending(x => x.DiscountRate);

                    return listfiltered[0].DiscountRate;
                }
            }

            return 0;
        }

        public void SetEventPrice(Product product)
        {
            product.EventPrice = product.Price * (100 - DataRepository.Product.GetDiscountRate(product))/100;
            return;
        }

        public List<ProductPartial> SearchByCategoryId(int categoryId)
        {
            var context = CreateContext();

            var query = from x in context.Products
                        where x.CodeCategoryId == categoryId
                        select new { x.ProductId, x.Name, x.Description, x.Price };

            var items = query.ToList();

            List<ProductPartial> partials = new List<ProductPartial>();

            foreach (var item in items)
            {
                ProductPartial partial = new ProductPartial();

                partial.ProductId = item.ProductId;
                partial.Name = item.Name;
                partial.Description = item.Description;
                partial.Price = item.Price;

                partials.Add(partial);
            }

            return partials;
        }

        public List<ProductPartial> GetAllPartial()
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.Products
                        select new {x.ProductId, x.Name };

            var items = query.ToList();

            List<ProductPartial> productPartials = new List<ProductPartial>();

            foreach (var item in items)
            {
                
                ProductPartial productPartial = new ProductPartial();
                productPartial.ProductId = item.ProductId;
                productPartial.Name = item.Name;
                productPartials.Add(productPartial);
            }

            return productPartials;
              
        }
    }
}
