using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class StockData : EntityData<Stock>
    {
        public Stock Get(int stockId)
        {
            LNTKEntities context = CreateContext();

            return context.Stocks.FirstOrDefault(a => a.StockId == stockId);
        }

        public void Delete(int stockId)
        {
            Stock stock = Get(stockId);

            if (stock == null)
                return;

            Delete(stock);
        }

        public int GetMaxId()
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.Stocks
                        orderby x.StockId descending
                        select x.StockId;

            return query.FirstOrDefault();

        }
    }
}
