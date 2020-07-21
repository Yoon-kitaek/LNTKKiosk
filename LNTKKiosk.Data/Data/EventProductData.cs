using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class EventProductData : EntityData<EventProduct>
    {
        public EventProduct Get(int eventId, int productId)
        {
            LNTKEntities context = CreateContext();

            return context.EventProducts.FirstOrDefault(a => a.EventId == eventId && a.ProductId == productId);
        }

        public void Delete(int eventId, int productId)
        {
            EventProduct eventProduct = Get(eventId, productId);

            if (eventProduct == null)
                return;

            Delete(eventProduct);
        }

        public List<EventProduct> GetByEvent(int eventId)
        {
            List<EventProduct> eventProducts = DataRepository.EventProduct.GetAll();

            eventProducts.RemoveAll(x => x.EventId != eventId);

            return eventProducts;
        }

        public List<EventProduct> GetByProduct(int productId)
        {
            List<EventProduct> eventProducts = DataRepository.EventProduct.GetAll();

            eventProducts.RemoveAll(x => x.ProductId != productId);

            return eventProducts;
        }
    }
}
