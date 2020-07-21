using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class OrderData : EntityData<Order>
    {
        public Order Get(int orderId)
        {
            LNTKEntities context = CreateContext();

            return context.Orders.FirstOrDefault(a => a.OrderId == orderId);
        }

        public void Delete(int orderId)
        {
            Order order = Get(orderId);

            if (order == null)
                return;

            Delete(order);
        }

        public int GetMaxId()
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.Orders
                        orderby x.OrderId descending
                        select x.OrderId;

            return query.FirstOrDefault();
        }
    }
}
