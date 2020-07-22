using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class DataRepository
    {
       
        public static EventData Event { get; } = new EventData();
        public static EventProductData EventProduct { get; } = new EventProductData();
        public static GroceryData Grocery { get; } = new GroceryData();
        public static OrderData Order { get; } = new OrderData();
        public static OrderDetailData OrderDetail { get; } = new OrderDetailData();
        public static OrderStockData OrderStock { get; } = new OrderStockData();
        public static ProductData Product { get; } = new ProductData();
        public static RecipeData Recipe { get; } = new RecipeData();
        public static StockData Stock { get; } = new StockData();
    }
}
