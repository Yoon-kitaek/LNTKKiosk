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

        public void SetEventPrice(Product product)
        {
            List<EventProduct> list = DataRepository.EventProduct.GetByProduct(product.ProductId);
            Event @event = new Event();
            if(list != null)
            {
                foreach(EventProduct eventProduct in list)
                {
                    @event = DataRepository.Event.Get(eventProduct.EventId);
                    if(DateTime.Now < @event.StartTime || DateTime.Now > @event.EndTime )
                    {
                        list.Remove(eventProduct);
                    }
                }
                
                if(list.Count>0)
                {                
                    list.OrderByDescending(x=>x.DiscountRate);
                
                    product.EventPrice = product.Price * (1-list[0].DiscountRate); 

                    return;
                }
            }           
            product.EventPrice = product.Price;
            
            return;
        }
    }
}
//