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

        public void CheckUsage(int orderDetailId)
        {
            OrderDetail orderDetail = DataRepository.OrderDetail.Get(orderDetailId);
            List<Recipe> originals = DataRepository.Recipe.GetByProduct(orderDetail.ProductId);
            List<ChangedRecipe> changes = DataRepository.ChangedRecipe.GetByOrderDetailId(orderDetailId);

            foreach (Recipe recipe in originals)
            {
                int index = changes.FindIndex(x => x.GroceryId == recipe.GroceryId);
                if (index != -1)
                    recipe.Amount += changes[index].Amount;
                
                if (recipe.Amount > 0)
                {
                    List<Stock> stocks = GetByGroceryId(recipe.GroceryId)
                                        .OrderBy(x => x.ReceivedDate)
                                        .SkipWhile(x => x.ExhaustedDate != null || ((DateTime.Now - x.ReceivedDate).Days > x.ExpirationDate))
                                        .Take(recipe.Amount)
                                        .ToList();

                    //if(stocks.Count == 0)
                    //{
                    //    Stock
                    //}
                    foreach (var stock in stocks)
                    {
                        stock.ExhaustedDate = DateTime.Now;
                        DataRepository.Stock.Update(stock);
                    }
                }

            }

        
        }

        public List<Stock> GetAllWithProperties()
        {
            LNTKEntities context = CreateContext();

            var query = from x in context.Stocks
                        where x.ExhaustedDate == null
                        select new
                        {
                            Stock = x,
                            GroceryName = x.Grocery.Item

                        };



            //var query = from x in context.Stocks
            //            select new { Stock = x, GroceryName = x.Grocery.Item, ReceivedDate
            //                RemainingTime = (x.ReceivedDate.AddDays((double)x.ExpirationDate)-DateTime.Now)};

            var items = query.ToList();

            foreach (var item in items)
            {
                item.Stock.GroceryName = item.GroceryName;
                //if(item.RemainingTime.Days > 0)
                item.Stock.RemainingTime = (item.Stock.ReceivedDate.AddDays(30) - DateTime.Now).Days;

            }

            return items.ConvertAll(x => x.Stock);

        }
    }
}