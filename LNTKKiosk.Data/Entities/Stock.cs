using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public partial class Stock
    {
        public string GroceryName { get; set; }
        public DateTime StockReceivedDate { get; set; }
        public DateTime StockExhaustedDate { get; set; }
        public int StockExpirationDay { get; set; }
        public int StockStatus { get; set; }



    }
}
