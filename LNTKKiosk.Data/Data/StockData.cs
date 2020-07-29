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

        public List<Stock> GetByGroceryId(int groceryId)
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.Stocks
                        where x.GroceryId == groceryId
                        select new { Stock = x, GroceryName = x.Grocery.Item };

            var items = query.ToList();

            foreach (var item in items)
            {
                item.Stock.GroceryName = item.GroceryName;
            }

            return items.ConvertAll(x => x.Stock);

        }

        public List<Stock> GetAllWithProperties()
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.Stocks
                        select new { Stock = x, StockReceivedDate = x.ReceivedDate, StockExhaustedDate = x.ExhaustedDate, StockExpirationDay = x.ExpirationDate };

            var items = query.ToList();

            foreach (var item in items)
            {
                item.Stock.ReceivedDate = item.StockReceivedDate;
                item.Stock.ExhaustedDate = item.StockExhaustedDate;
                item.Stock.ExpirationDate = item.StockExpirationDay;
            }

            return items.ConvertAll(x => x.Stock);

        }
    }
}
