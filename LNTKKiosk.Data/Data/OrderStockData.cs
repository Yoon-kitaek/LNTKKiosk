using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class OrderStockData : EntityData<OrderStock>
    {
        public OrderStock Get(int orderId, int stockId)
        {
            LNTKEntities context = CreateContext();

            return context.OrderStocks.FirstOrDefault(a => a.OrderId == orderId && a.StockId == stockId);
        }

        public void Delete(int orderId, int stockId)
        {
            OrderStock orderStock = Get(orderId, stockId);

            if (orderStock == null)
                return;

             Delete(orderStock);
        }
    }
}
