using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNTKKiosk.Data
{
    public class ShoppedItem
    {
        public ShoppedItem(string packageName, int productId, int qunatity, int price)
        {
            this.packageName = packageName;
            this.productId = productId;
            productName = DataRepository.Product.Get(productId).Name;
            this.quantity = qunatity;
            this.price = price;
            totalPrice = this.quantity * this.price;
        }
        public string packageName { get; set; }       
        public int productId { get; set; }
        public string productName { get; private set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public int totalPrice { get; set; }


    }
}
